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
        public byte[] DecorationChunk4;
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
                coll.Modifier = reader.ReadByte();
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
                MLandDecoration.Add(deco);
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
                FLandDecoration.Add(deco);
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
                BLandDecoration.Add(deco);
            }

            reader.BaseStream.Seek(pos + 0xC, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            reader.BaseStream.Seek(-4, SeekOrigin.Current);
            DecorationChunk4 = reader.ReadBytes((int)(0x40 * count) + 0xC);

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

            reader.Dispose();
            reader.Close();
        }

        public void Write(BigEndianBinaryWriter writer)
        {
            writer.Write(new byte[] {
                0x58, 0x42, 0x49, 0x4E, 0x12, 0x34, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFD, 0xE9,
                0x00, 0x00, 0x00, 0x22, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x68, 0x00, 0x00, 0xC0, 0x94, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x12, 0x34, 0x56, 0x78 });
            writer.Write(Bosses.Count);
            for (int i = 0; i < Bosses.Count; i++)
            {
                writer.Write(Bosses[i].Type);
                writer.Write(Bosses[i].Param1);
                writer.Write(Bosses[i].Param2);
                writer.Write(Bosses[i].Param3);
                writer.Write(Convert.ToUInt32(Bosses[i].HasSuperAbility));
                writer.Write(ConvertCoords(new uint[] { Bosses[i].X, Bosses[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Bosses[i].Y, Bosses[i].YOffset }));
            }
            uint pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x18, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(SpecialItems.Count);
            for (int i = 0; i < SpecialItems.Count; i++)
            {
                writer.Write(SpecialItems[i].Type);
                writer.Write(SpecialItems[i].AppearID);
                writer.Write(Convert.ToUInt32(SpecialItems[i].Respawn));
                writer.Write(SpecialItems[i].MovingTerrainID);
                writer.Write(ConvertCoords(new uint[] { SpecialItems[i].X, SpecialItems[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { SpecialItems[i].Y, SpecialItems[i].YOffset }));
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x1C, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(1);
            writer.Write((uint)writer.BaseStream.Position + 0x4);
            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < TileCollision.Count; i++)
            {
                writer.Write(TileCollision[i].Shape);
                writer.Write(TileCollision[i].Modifier);
                writer.Write(TileCollision[i].Material);
                writer.Write(TileCollision[i].AutoMoveSpeed);
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x20, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(0);
            pos = (uint)writer.BaseStream.Position + (4 * 16);
            for (int i = 0; i < 16; i++)
            {
                writer.Write(pos);
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x24, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Background);
            writer.Write(Tileset);
            pos = (uint)writer.BaseStream.Position;
            writer.Write(pos + (4 * 4));
            writer.Write(0);
            writer.Write(0);
            writer.Write(0);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < MLandDecoration.Count; i++)
            {
                writer.Write(MLandDecoration[i].Unk_1);
                writer.Write(MLandDecoration[i].Unk_2);
                writer.Write(MLandDecoration[i].Unk_3);
                writer.Write(MLandDecoration[i].MovingTerrainID);
            }
            writer.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < FLandDecoration.Count; i++)
            {
                writer.Write(FLandDecoration[i].Unk_1);
                writer.Write(FLandDecoration[i].Unk_2);
                writer.Write(FLandDecoration[i].Unk_3);
                writer.Write(FLandDecoration[i].MovingTerrainID);
            }
            writer.BaseStream.Seek(pos + 0x8, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < BLandDecoration.Count; i++)
            {
                writer.Write(BLandDecoration[i].Unk_1);
                writer.Write(BLandDecoration[i].Unk_2);
                writer.Write(BLandDecoration[i].Unk_3);
                writer.Write(BLandDecoration[i].MovingTerrainID);
            }
            writer.BaseStream.Seek(pos + 0xC, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(DecorationChunk4);
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x28, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Enemies.Count);
            for (int i = 0; i < Enemies.Count; i++)
            {
                writer.Write(Enemies[i].Type);
                writer.Write(Enemies[i].Behavior);
                writer.Write(Enemies[i].Param1);
                writer.Write(Enemies[i].Param2);
                writer.Write(Enemies[i].SizeAD);
                writer.Write(Enemies[i].SizeEX);
                writer.Write(Enemies[i].MovingTerrainID);
                writer.Write(Convert.ToUInt32(Enemies[i].HasSuperAbility));
                writer.Write(ConvertCoords(new uint[] { Enemies[i].X, Enemies[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Enemies[i].Y, Enemies[i].YOffset }));
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x2C, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            uint bgmOffset = (uint)writer.BaseStream.Position;
            writer.Write(0);
            writer.Write(StageData.BgX);
            writer.Write(StageData.BgY);
            writer.Write(StageData.BgZ);
            writer.Write(StageData.BgRotX);
            writer.Write(StageData.BgRotY);
            writer.Write(StageData.BgRotZ);
            writer.Write(StageData.BgDistance);
            writer.Write(StageData.BgScrollSpeedX);
            writer.Write(StageData.BgScrollDownX);
            writer.Write(StageData.BgScrollBackX);
            writer.Write(StageData.BgScrollRightY);
            writer.Write(StageData.BgScrollSpeedY);
            writer.Write(StageData.BgScrollBackY);
            writer.Write(StageData.Filter);
            writer.Write(StageData.RunEffect);
            writer.Write(StageData.DeathStepFlag);
            writer.Write(StageData.DeathStepChange);
            writer.Write(StageData.DeathStartID);
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x30, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            pos = (uint)writer.BaseStream.Position;
            writer.Write(pos + (3 * 4));
            writer.Write(0);
            writer.Write(0);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < TileBlock.Count; i++)
            {
                writer.Write(TileBlock[i].ID);
            }
            writer.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Objects.Count);
            for (int i = 0; i < Objects.Count; i++)
            {
                writer.Write(Objects[i].Type);
                writer.Write(ConvertCoords(new uint[] { Objects[i].X, Objects[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Objects[i].Y, Objects[i].YOffset }));
                writer.Write(Objects[i].Param1);
                writer.Write(Objects[i].Param2);
                writer.Write(Objects[i].Param3);
                writer.Write(Objects[i].Param4);
                writer.Write(Objects[i].Param5);
                writer.Write(Objects[i].Param6);
                writer.Write(Objects[i].Param7);
                writer.Write(Objects[i].Param8);
                writer.Write(Objects[i].Param9);
                writer.Write(Objects[i].Param10);
                writer.Write(Objects[i].Param11);
                writer.Write(Objects[i].Param12);
                writer.Write(Objects[i].Unknown);
            }
            writer.BaseStream.Seek(pos + 0x8, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            uint offset = 0x0;
            List<uint> actionTableOffsets = new List<uint>();
            writer.Write(0);
            for (int i = 0; i < 16; i++)
            {
                writer.Write((uint)writer.BaseStream.Length + 0x40 + offset);
                offset += 0xC;
                actionTableOffsets.Add((uint)writer.BaseStream.Length + 0x40 + offset);
            }
            for (int i = 0; i < 16; i++)
            {
                writer.Write(new byte[] { 0xFF, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 });
                writer.Write(actionTableOffsets[i]);
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x34, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Items.Count);
            for (int i = 0; i < Items.Count; i++)
            {
                writer.Write(Items[i].Type);
                writer.Write(Items[i].SubType);
                writer.Write(Items[i].Behavior);
                writer.Write(Items[i].MovingTerrainID);
                writer.Write(ConvertCoords(new uint[] { Items[i].X, Items[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Items[i].Y, Items[i].YOffset }));
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(bgmOffset, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);
            writer.Write(StageData.BGM.Length);
            writer.Write(Encoding.UTF8.GetBytes(StageData.BGM));
            writer.Write(0);

            writer.BaseStream.Seek(0x8, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);

            writer.Flush();
            writer.Dispose();
            writer.Close();
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
            return uint.Parse(c, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
