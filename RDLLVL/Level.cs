using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using RDLLVL;

namespace RDLLVL
{
    public class Level
    {
        public uint Height;
        public uint Width;
        public uint Background;
        public uint Tileset;
        public Stage StageData;
        public List<Block> TileBlock = new List<Block>();
        public List<Collision> TileCollision = new List<Collision>();
        public List<Decoration> BLandDecoration = new List<Decoration>();
        public List<Decoration> MLandDecoration = new List<Decoration>();
        public List<Decoration> FLandDecoration = new List<Decoration>();
        public List<byte> Unk_Decoration = new List<byte>();
        public List<Object> Objects = new List<Object>();
        public List<SpecialItem> SpecialItems = new List<SpecialItem>();
        public List<Item> Items = new List<Item>();
        public List<Boss> Bosses = new List<Boss>();
        public List<Enemy> Enemies = new List<Enemy>();

        public Level(string filePath)
        {
            using (BigEndianBinaryReader reader = new BigEndianBinaryReader(new FileStream(filePath, FileMode.Open)))
            {
                Read(reader);
            }
        }

        public void Read(BigEndianBinaryReader reader)
        {
            reader.BaseStream.Seek(0x14, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            uint count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Boss boss = new Boss();
                boss.Type = reader.ReadUInt32();
                boss.Param1 = reader.ReadUInt32();
                boss.Param2 = reader.ReadUInt32();
                boss.Param3 = reader.ReadUInt32();
                boss.HasSuperAbility = Convert.ToBoolean(reader.ReadUInt32());
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                boss.X = x[0];
                boss.XOffset = x[1];
                boss.Y = y[0];
                boss.YOffset = y[1];
                Bosses.Add(boss);
            }

            reader.BaseStream.Seek(0x18, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                SpecialItem specItem = new SpecialItem();
                specItem.Type = reader.ReadUInt32();
                specItem.AppearID = reader.ReadUInt32();
                specItem.Respawn = Convert.ToBoolean(reader.ReadUInt32());
                specItem.MovingTerrainID = reader.ReadInt32();
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                specItem.X = x[0];
                specItem.XOffset = x[1];
                specItem.Y = y[0];
                specItem.YOffset = y[1];
                SpecialItems.Add(specItem);
            }

            reader.BaseStream.Seek(0x1C, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x4, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            Width = reader.ReadUInt32();
            Height = reader.ReadUInt32();
            for (int i = 0; i < Width * Height; i++)
            {
                Collision coll = new Collision();
                coll.Shape = reader.ReadByte();
                coll.Type = reader.ReadByte();
                coll.Material = reader.ReadByte();
                coll.AutoMoveSpeed = reader.ReadSByte();
                TileCollision.Add(coll);
            }

            reader.BaseStream.Seek(0x24, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            Background = reader.ReadUInt32();
            Tileset = reader.ReadUInt32();
            long pos = reader.BaseStream.Position;

            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Decoration deco = new Decoration();
                deco.Unk_1 = reader.ReadByte();
                deco.Unk_2 = reader.ReadByte();
                deco.Unk_3 = reader.ReadByte();
                deco.MovingTerrainID = reader.ReadSByte();
                BLandDecoration.Add(deco);
            }

            reader.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Decoration deco = new Decoration();
                deco.Unk_1 = reader.ReadByte();
                deco.Unk_2 = reader.ReadByte();
                deco.Unk_3 = reader.ReadByte();
                deco.MovingTerrainID = reader.ReadSByte();
                MLandDecoration.Add(deco);
            }

            reader.BaseStream.Seek(pos + 0x8, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Decoration deco = new Decoration();
                deco.Unk_1 = reader.ReadByte();
                deco.Unk_2 = reader.ReadByte();
                deco.Unk_3 = reader.ReadByte();
                deco.MovingTerrainID = reader.ReadSByte();
                FLandDecoration.Add(deco);
            }

            reader.BaseStream.Seek(0x28, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Enemy enemy = new Enemy();
                enemy.Type = reader.ReadUInt32();
                enemy.Behavior = reader.ReadUInt32();
                enemy.Param1 = reader.ReadUInt32();
                enemy.Param2 = reader.ReadUInt32();
                enemy.SizeAD = reader.ReadUInt32();
                enemy.SizeEX = reader.ReadUInt32();
                enemy.MovingTerrainID = reader.ReadInt32();
                enemy.HasSuperAbility = Convert.ToBoolean(reader.ReadUInt32());
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                enemy.X = x[0];
                enemy.XOffset = x[1];
                enemy.Y = y[0];
                enemy.YOffset = y[1];
                Enemies.Add(enemy);
            }

            reader.BaseStream.Seek(0x2C, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            pos = reader.BaseStream.Position;
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            StageData = new Stage();
            StageData.BGM = Encoding.UTF8.GetString(reader.ReadBytes(reader.ReadInt32()));
            reader.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            StageData.BgX = reader.ReadSingle();
            StageData.BgY = reader.ReadSingle();
            StageData.BgZ = reader.ReadSingle();
            StageData.BgRotX = reader.ReadSingle();
            StageData.BgRotY = reader.ReadSingle();
            StageData.BgRotZ = reader.ReadSingle();
            StageData.BgDistance = reader.ReadSingle();
            StageData.BgScrollSpeedX = reader.ReadSingle();
            StageData.BgScrollDownX = reader.ReadSingle();
            StageData.BgScrollBackX = reader.ReadSingle();
            StageData.BgScrollRightY = reader.ReadSingle();
            StageData.BgScrollSpeedY = reader.ReadSingle();
            StageData.BgScrollBackY = reader.ReadSingle();
            StageData.Filter = reader.ReadUInt32();
            StageData.RunEffect = reader.ReadUInt32();
            StageData.DeathStepFlag = reader.ReadUInt32();
            StageData.DeathStepChange = reader.ReadInt32();
            StageData.DeathStartID = reader.ReadUInt32();

            reader.BaseStream.Seek(0x30, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            pos = reader.BaseStream.Position;
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Block block = new Block();
                block.ID = reader.ReadInt16();
                TileBlock.Add(block);
            }

            reader.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Object obj = new Object();
                obj.Type = reader.ReadUInt32();
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                obj.X = x[0];
                obj.XOffset = x[1];
                obj.Y = y[0];
                obj.YOffset = y[1];
                obj.Param1 = reader.ReadUInt32();
                obj.Param2 = reader.ReadUInt32();
                obj.Param3 = reader.ReadUInt32();
                obj.Param4 = reader.ReadUInt32();
                obj.Param5 = reader.ReadUInt32();
                obj.Param6 = reader.ReadUInt32();
                obj.Param7 = reader.ReadUInt32();
                obj.Param8 = reader.ReadUInt32();
                obj.Param9 = reader.ReadUInt32();
                obj.Param10 = reader.ReadUInt32();
                obj.Param11 = reader.ReadUInt32();
                obj.Param12 = reader.ReadUInt32();
                obj.Unknown = reader.ReadUInt32();
                Objects.Add(obj);
            }

            reader.BaseStream.Seek(0x34, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Item item = new Item();
                item.Type = reader.ReadUInt32();
                item.SubType = reader.ReadUInt32();
                item.Behavior = reader.ReadUInt32();
                item.MovingTerrainID = reader.ReadInt32();
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                item.X = x[0];
                item.XOffset = x[1];
                item.Y = y[0];
                item.YOffset = y[1];
                Items.Add(item);
            }
        }

        private uint[] ConvertCoords(uint coord)
        {
            string c = coord.ToString("X8").Remove(7, 1);
            string o = coord.ToString("X8").Remove(0, 7);
            return new uint[] { uint.Parse(c, System.Globalization.NumberStyles.HexNumber), uint.Parse(o, System.Globalization.NumberStyles.HexNumber) };
        }
        private uint ConvertCoords(uint[] coord)
        {
            string c = coord[0].ToString("X7") + coord[1].ToString("X1");
            return uint.Parse(c);
        }
    }
}
