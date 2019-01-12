using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RDLLVL
{
    public class BigEndianBinaryReader : BinaryReader
    {
        public BigEndianBinaryReader(Stream stream) : base(stream) { }
        
        public override short ReadInt16()
        {
            var data = base.ReadBytes(2);
            return BitConverter.ToInt16(data.Reverse().ToArray(), 0);
        }

        public override ushort ReadUInt16()
        {
            var data = base.ReadBytes(2);
            return BitConverter.ToUInt16(data.Reverse().ToArray(), 0);
        }

        public override int ReadInt32()
        {
            var data = base.ReadBytes(4);
            return BitConverter.ToInt32(data.Reverse().ToArray(), 0);
        }

        public override uint ReadUInt32()
        {
            var data = base.ReadBytes(4);
            return BitConverter.ToUInt32(data.Reverse().ToArray(), 0);
        }

        public override long ReadInt64()
        {
            var data = base.ReadBytes(8);
            return BitConverter.ToInt64(data.Reverse().ToArray(), 0);
        }

        public override ulong ReadUInt64()
        {
            var data = base.ReadBytes(8);
            return BitConverter.ToUInt64(data.Reverse().ToArray(), 0);
        }

        public override float ReadSingle()
        {
            var data = base.ReadBytes(4);
            return BitConverter.ToSingle(data.Reverse().ToArray(), 0);
        }

    }
}
