using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using SerialPortLib;

namespace AIUISerials
{
    public delegate void AIUIConnectionReceivedDelegate(object sender, AIUIConnectionReceivedEventArgs args);

    public class AIUIConnectionReceivedEventArgs : EventArgs
    {
        public string Json { get; set; }

        public byte[] Source { get; set; }

        public AIUIConnectionReceivedEventArgs(string str,byte[] data)
        {
            Json = str;
            Source = data;
        }
    }

    public class AIUIConnection
    {
        public AIUIDebuger.AIUI aiui;

        private SerialPortInput _serialPort = null;
        /// <summary>
        /// 串口连接
        /// </summary>
        public SerialPortInput SerialPort
        {
            get { return _serialPort; }
        }

        private int serailDataLength = 0;
        private PacketBuilder packetBuilder = new PacketBuilder();
        private MemoryStream receiveBuffer = null;
        private byte[] packageHeader = new byte[] { 0xA5, 0x01 };

        private bool _enabledAutoReply = true;
        /// <summary>
        /// 是否支持自动回复
        /// </summary>
        public bool EnabledAutoReply
        {
            get { return _enabledAutoReply; }
            set { _enabledAutoReply = value; }
        }

        public event AIUIConnectionReceivedDelegate AIUIConnectionReceivedEvent;

        protected void OnAIUIConnectionReceivedEvent(string json,byte[] data)
        {
            if (AIUIConnectionReceivedEvent != null)
            {
                AIUIConnectionReceivedEvent(this, new AIUIConnectionReceivedEventArgs(json,data));
            }
        }

        public AIUIConnection(string comPort, int baudrate)
        {
            _serialPort = new SerialPortInput();
            _serialPort.SetPort(comPort, baudrate, System.IO.Ports.StopBits.One, System.IO.Ports.Parity.None, 100, -1);
            _serialPort.MessageReceived += _serialPort_MessageReceived;
            
        }

        void _serialPort_MessageReceived(object sender, MessageReceivedEventArgs args)
        {
            if (receiveBuffer == null)
            {
                receiveBuffer = new MemoryStream();
            }

            //查询开始位置
            int offset = IndexOf(args.Data,packageHeader);
            if (offset>= 0)
            {
               //遇到包头则重新生成内存流开始缓存
               if (receiveBuffer!= null)
               {
                  receiveBuffer.Dispose();
               }

               receiveBuffer = new MemoryStream();
               receiveBuffer.Write(args.Data,offset,args.Data.Length - offset);
            }else
            {
               //不是包头继续累加数据
               receiveBuffer.Position = receiveBuffer.Length;
               receiveBuffer.Write(args.Data,0,args.Data.Length);
            }

            //解析长度
            receiveBuffer.Position = 3;
            byte[] lengthBytes = new byte[2];
            receiveBuffer.Read(lengthBytes,0,lengthBytes.Length);
            short length = BitConverter.ToInt16(lengthBytes,0);

            //判断是否已收到完整数据包
            if (receiveBuffer.Length >= length + 8)
            {
                //取数据
                byte[] packet = receiveBuffer.ToArray();

                //结束receiveBuffer
                receiveBuffer.Dispose();
                receiveBuffer = null;

                if (packet[packet.Length - 1] == Utils.CalcCheckCode(new List<byte>(packet)))
                {
                    //取ID
                    int id = ((packet[6] & 0xff) << 8) + packet[5];

                    //设置ID
                    packetBuilder.setSeqId(id);

                    //自动回复
                    if (EnabledAutoReply)
                    {
                        SendConfirmMessage();
                    }

                    //处理消息
                    ProcessMsg(packet, length);
                }
            }
        }
        
        /// <summary>
        /// 投递Json消息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="contentLen"></param>
        private void ProcessMsg(byte[] source, int contentLen) {
            if (source[2] == 0x04)
            {
                byte[] data = new byte[contentLen];
                Array.Copy(source, 7, data, 0, data.Length);

                if (aiui.getIsConsoleOn())
                {
                    LogRecieve(data);
                }

                //投递消息事件
                OnAIUIConnectionReceivedEvent(Utils.Decompress(data), data);
            }
        }

        public void SendShake()
        {
            SendToCard(packetBuilder.buildShakePacket().ToArray());
        }

        public void SendConfirmMessage()
        {
            SendToCard(packetBuilder.buildConfirmPacket().ToArray());
        }

        public void SendTTSMessage(string text)
        {
            SendToCard(packetBuilder.buildTtsPacket(text).ToArray());
        }

        public void ConfigWifiMessage(string config)
        {
            SendToCard(packetBuilder.buildWifiCfgPacket(config).ToArray());
        }

        public void SendAIUIConfigMessage(string config)
        {
            SendToCard(packetBuilder.buildAIUIConfigPacket(config).ToArray());
        }

        public void SendLauchVoiceMessage(Boolean isOn)
        {
            SendToCard(packetBuilder.buildVoiceControlPacket(isOn).ToArray());
        }

        public void SendSmartConfigMessage(Boolean isOn)
        {
            SendToCard(packetBuilder.buildSmartConfigPacket(isOn).ToArray());
        }

        public void SendWakeUpMessage(Boolean isReset)
        {
            SendToCard(packetBuilder.buildResetWakePacket(isReset).ToArray());
        }

        public void SendCustomMessage(byte[] data)
        {
            SendToCard(packetBuilder.buildCustomDataPacket(data).ToArray());
        }

        public void SendCmd(string sendCmd)
        {
            SendToCard(packetBuilder.buildCmdPacket(sendCmd).ToArray());
        }

        public void SendToCard(byte[] content)
        {
            SerialPort.SendMessage(content);

            if (aiui.getIsConsoleOn())
            {
                LogSend(content);
            }
        }

        /// <summary>
        /// 报告指定的 System.Byte[] 在此实例中的第一个匹配项的索引。
        /// </summary>
        /// <param name="srcBytes">被执行查找的 System.Byte[]。</param>
        /// <param name="searchBytes">要查找的 System.Byte[]。</param>
        /// <returns>如果找到该字节数组，则为 searchBytes 的索引位置；如果未找到该字节数组，则为 -1。如果 searchBytes 为 null 或者长度为0，则返回值为 -1。</returns>
        public int IndexOf(byte[] srcBytes, byte[] searchBytes)
        {
            if (srcBytes == null) { return -1; }
            if (searchBytes == null) { return -1; }
            if (srcBytes.Length == 0) { return -1; }
            if (searchBytes.Length == 0) { return -1; }
            if (srcBytes.Length < searchBytes.Length) { return -1; }
            for (int i = 0; i < srcBytes.Length - searchBytes.Length; i++)
            {
                if (srcBytes[i] == searchBytes[0])
                {
                    if (searchBytes.Length == 1) { return i; }
                    bool flag = true;
                    for (int j = 1; j < searchBytes.Length; j++)
                    {
                        if (srcBytes[i + j] != searchBytes[j])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag) { return i; }
                }
            }
            return -1;
        }

        private void LogSend(byte[] send)
        {
            string logData = "";
            for (int index = 0; index < send.Length; index++)
            {
                if (index == 0)
                {
                    logData += "Send :[ ";
                }
                if (index == send.Length - 1)
                {
                    logData += Convert.ToString(send[index]) + "]\n\n";
                }
                else
                {
                    logData += Convert.ToString(send[index]) + ", ";
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(logData);

        }

        private void LogRecieve(byte[] recive)
        {
            string logData = "";
            for (int index = 0; index < recive.Length; index++)
            {
                if (index == 0)
                {
                    logData += "Recived :[ ";
                }
                if (index == recive.Length - 1)
                {
                    logData += Convert.ToString(recive[index]) + "]\n\n";
                }
                else
                {
                    logData += Convert.ToString(recive[index]) + ", ";
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(logData);
        }
    }
}