using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDLLVL
{
    public struct Object
    {
        public uint Type;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
        public uint Param1;
        public uint Param2;
        public uint Param3;
        public uint Param4;
        public uint Param5;
        public uint Param6;
        public uint Param7;
        public uint Param8;
        public uint Param9;
        public uint Param10;
        public uint Param11;
        public uint Param12;
        public uint Unknown;
    }

    public struct SpecialItem
    {
        public uint Type;
        public uint AppearID;
        public bool Respawn;
        public int MovingTerrainID;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Item
    {
        public uint Type;
        public uint SubType;
        public uint Behavior;
        public int MovingTerrainID;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Boss
    {
        public uint Type;
        public uint Param1;
        public uint Param2;
        public uint Param3;
        public bool HasSuperAbility;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Enemy
    {
        public uint Type;
        public uint Behavior;
        public uint Param1;
        public uint Param2;
        public uint SizeAD;
        public uint SizeEX;
        public int MovingTerrainID;
        public bool HasSuperAbility;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Block
    {
        public short ID;
    }

    public struct Collision
    {
        public byte Shape;
        public byte Modifier;
        public byte Material;
        public sbyte AutoMoveSpeed;
    }

    public struct Decoration
    {
        public byte Unk_1;
        public byte Unk_2;
        public byte Unk_3;
        public sbyte MovingTerrainID;
    }

    public struct Stage
    {
        public string BGM;
        public float BgX;
        public float BgY;
        public float BgZ;
        public float BgRotX;
        public float BgRotY;
        public float BgRotZ;
        public float BgDistance;
        public float BgScrollSpeedX;
        public float BgScrollDownX;
        public float BgScrollBackX;
        public float BgScrollRightY;
        public float BgScrollSpeedY;
        public float BgScrollBackY;
        public uint Filter;
        public uint RunEffect;
        public uint DeathStepFlag;
        public int DeathStepChange;
        public uint DeathStartID;
    }
}
