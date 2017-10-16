using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

namespace WindowsFormsApplication1
{
    class PMS
    {
        private SerialPort _port;
        private List<byte> _frame = new List<byte>(); // Only for visualization

        public class DataEventArgs : EventArgs
        {
            private byte[] _payload;

            public DataEventArgs(byte[] payload)
            {
                this._payload = payload;
            }

            public int PM_FE_UG_1_0 { get { return (ushort)((_payload[0] << 8) | _payload[1]); } }
            public int PM_FE_UG_2_5 { get { return (ushort)((_payload[2] << 8) | _payload[3]); } }
            public int PM_FE_UG_10_0 { get { return (ushort)((_payload[4] << 8) | _payload[5]); } }

            public int PM_AE_UG_1_0 { get { return (ushort)((_payload[6] << 8) | _payload[7]); } }
            public int PM_AE_UG_2_5 { get { return (ushort)((_payload[8] << 8) | _payload[9]); } }
            public int PM_AE_UG_10_0 { get { return (ushort)((_payload[10] << 8) | _payload[11]); } }

            public byte[] Payload { get { return _payload; } }
        }

        public class RawDataEventArgs : EventArgs
        {
            private string _text;

            public RawDataEventArgs(string text)
            {
                this._text = text;
            }

            public string Data { get { return _text; } }
        }

        public delegate void DataEventHandler(object sender, DataEventArgs e);
        public delegate void FeedbackEventHandler(object sender, RawDataEventArgs e);

        public event DataEventHandler DataEvent;
        public event FeedbackEventHandler FeedbackEvent;

        private byte[] _payload = new byte[12];
        private ushort _index, _frameLen, _checksum, _calculatedChecksum;

        public PMS(SerialPort port)
        {
            this._port = port;
            this._port.DataReceived += Port_DataReceived;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (this._port.BytesToRead > 0)
            {
                loop();
            }
        }

        private void SendData(byte[] data)
        {
            if (this._port.IsOpen)
            {
                this._port.Write(data, 0, data.Length);
                this.FeedbackEvent?.Invoke(this, new RawDataEventArgs("> " + string.Join(" ", data.Select(c => ((byte)c).ToString("X2")))));
            }
        }

        public void Sleep()
        {
            SendData(new byte[] { 0x42, 0x4D, 0xE4, 0x00, 0x00, 0x01, 0x73 });
        }

        public void WakeUp()
        {
            SendData(new byte[] { 0x42, 0x4D, 0xE4, 0x00, 0x01, 0x01, 0x74 });
        }

        public void PassiveMode()
        {
            SendData(new byte[] { 0x42, 0x4D, 0xE1, 0x00, 0x00, 0x01, 0x70 });
        }

        public void ActiveMode()
        {
            SendData(new byte[] { 0x42, 0x4D, 0xE1, 0x00, 0x01, 0x01, 0x71 });
        }

        public void Read()
        {
            SendData(new byte[] { 0x42, 0x4D, 0xE2, 0x00, 0x00, 0x01, 0x71 });
        }

        private void loop()
        {
            byte ch = (byte)this._port.ReadByte();
            if (_index == 0) _frame.Clear(); else _frame.Add(ch);

            switch (_index)
            {
                case 0:
                    if (ch != 0x42)
                    {
                        return;
                    }
                    _calculatedChecksum = ch;
                    break;

                case 1:
                    if (ch != 0x4D)
                    {
                        _index = 0;
                        return;
                    }
                    _calculatedChecksum += ch;
                    break;

                case 2:
                    _calculatedChecksum += ch;
                    _frameLen = (ushort)(ch << 8);
                    break;

                case 3:
                    _frameLen |= ch;
                    if (_frameLen != 2 * 9 + 2 && _frameLen != 2 * 13 + 2)
                    {
                        _index = 0;
                        return;
                    }
                    _calculatedChecksum += ch;
                    break;

                default:
                    if (_index == _frameLen + 2)
                    {
                        _checksum = (ushort)(ch << 8);
                    }
                    else if (_index == _frameLen + 2 + 1)
                    {
                        _checksum |= ch;

                        if (_calculatedChecksum == _checksum)
                        {
                            FeedbackEvent?.Invoke(this, new RawDataEventArgs("< " + string.Join(" ", _frame.Select(c => ((byte)c).ToString("X2")))));
                            DataEvent?.Invoke(this, new DataEventArgs(_payload));
                        }

                        _index = 0;
                        return;
                    }
                    else
                    {
                        _calculatedChecksum += ch;
                        byte payloadIndex = (byte)(_index - 4);

                        if (payloadIndex < _payload.Length)
                        {
                            _payload[payloadIndex] = ch;
                        }
                    }
                    break;
            }
            _index++;
        }
    }
}
