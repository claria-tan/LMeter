namespace LMeter.Helpers
{
    public enum RoundingFlag
    {
        All,
        Left,
        Right,
        Top,
        TopRight,
        TopLeft,
        Bottom,
        BottomRight,
        BottomLeft
    }

    public enum BooleanOperator
    {
        And,
        Or,
        Xor
    }

    public enum VisibilityConditionType
    {
        AlwaysTrue,
        InCombat,
        InDuty,
        Performing,
        Zone,
        Job
    }

    public enum ZoneType
    {
        GoldSaucer,
        PlayerHouse
    }
    
    public enum MeterDataType
    {
        Damage,
        Healing,
        DamageTaken,
        Rdps,
        Adps,
        Ndps,
        Cdps,
        RawDps
    }

    public enum ConnectionStatus
    {
        NotConnected,
        Connected,
        ShuttingDown,
        Connecting,
        ConnectionFailed
    }

    public enum Job
    {
        UKN = 0,

        GLA = 1,
        MRD = 3,
        PLD = 19,
        WAR = 21,
        DRK = 32,
        GNB = 37,

        CNJ = 6,
        WHM = 24,
        SCH = 28,
        AST = 33,
        SGE = 40,

        PGL = 2,
        LNC = 4,
        ROG = 29,
        MNK = 20,
        DRG = 22,
        NIN = 30,
        SAM = 34,
        RPR = 39,
        VPR = 41,

        ARC = 5,
        BRD = 23,
        MCH = 31,
        DNC = 38,

        THM = 7,
        ACN = 26,
        BLM = 25,
        SMN = 27,
        RDM = 35,
        PCT = 42,
        BLU = 36,

        CRP = 8,
        BSM = 9,
        ARM = 10,
        GSM = 11,
        LTW = 12,
        WVR = 13,
        ALC = 14,
        CUL = 15,

        MIN = 16,
        BOT = 17,
        FSH = 18
    }

    public enum JobType
    {
        All,
        Custom,
        Tanks,
        Casters,
        Melee,
        Ranged,
        Healers,
        DoW,
        DoM,
        Combat,
        Crafters,
        DoH,
        DoL
    }

    public enum DrawAnchor
    {
        Center = 0,
        Left = 1,
        Right = 2,
        Top = 3,
        TopLeft = 4,
        TopRight = 5,
        Bottom = 6,
        BottomLeft = 7,
        BottomRight = 8
    }
}
