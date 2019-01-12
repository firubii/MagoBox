using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RDLLVL
{
    public class BigEndianBinaryWriter : BinaryWriter
    {
        public BigEndianBinaryWriter(Stream stream) : base (stream) { }

        public override void Write(short value)
        {
            base.Write(InvertEndianness(value));
        }

        public override void Write(ushort value)
        {
            base.Write(InvertEndianness(value));
        }

        public override void Write(int value)
        {
            base.Write(InvertEndianness(value));
        }

        public override void Write(uint value)
        {
            base.Write(InvertEndianness(value));
        }

        public override void Write(float value)
        {
            base.Write(InvertEndianness(value));
        }

        private short InvertEndianness(short val)
        {
            return (short)(((val & 0x00ff) << 8) +
                           ((val & 0xff00) >> 8));
        }

        private ushort InvertEndianness(ushort val)
        {
            return (ushort)(((val & 0x00ff) << 8) +
                            ((val & 0xff00) >> 8));
        }

        private int InvertEndianness(int val)
        {
            return (int)(((val & 0x000000ff) << 24) +
                         ((val & 0x0000ff00) << 8) +
                         ((val & 0x00ff0000) >> 8) +
                         ((val & 0xff000000) >> 24));
        }

        private uint InvertEndianness(uint val)
        {
            return ((val & 0x000000ff) << 24) +
                   ((val & 0x0000ff00) << 8) +
                   ((val & 0x00ff0000) >> 8) +
                   ((val & 0xff000000) >> 24);
        }

        private float InvertEndianness(float val)
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(val).Reverse().ToArray(), 0);
        }
    }
}
