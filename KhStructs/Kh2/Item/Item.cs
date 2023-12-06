namespace KhStructs.Kh2.Item;

// Taken from https://openkh.dev/kh2/dictionary/inventory.html.
public enum Item : ushort {
    None = 0,
    Potion = 1,
    HiPotion = 2,
    Ether = 3,
    Elixir = 4,
    MegaPotion = 5,
    MegaEther = 6,
    Megalixir = 7,
    AbilityRing = 8,
    EngineersRing = 9,
    TechniciansRing = 10,
    ExpertsRing = 11,
    SardonyxRing = 12,
    TourmalineRing = 13,
    AquamarineRing = 14,
    GarnetRing = 15,
    DiamondRing = 16,
    SilverRing = 17,
    GoldRing = 18,
    PlatinumRing = 19,
    MythrilRing = 20,
    FireElement = 21,
    BlizzardElement = 22,
    ThunderElement = 23,
    CureElement = 24,
    UkuleleCharm = 25,
    ValorForm = 26,
    WisdomForm = 27,
    OrichalcumRing = 28,
    FinalForm = 29,
    AntiForm = 30,
    MasterForm = 31,
    TornPages = 32,
    MastersRing = 34,
    MoonAmulet = 35,
    StarCharm = 36,
    SkillRing = 38,
    SkillfulRing = 39,
    SoldierEarring = 40,
    KingdomKey = 41,
    Oathkeeper = 42,
    Oblivion = 43,
    DetectionSaber = 44,
    EdgeOfUltima = 45,
    FencerEarring = 46,
    MageEarring = 47,
    SlayerEarring = 48,
    KnightsShield = 49,
    DetectionShield = 50,
    TestTheKing = 51,
    CosmicRing = 52,
    Medal = 53,
    BattlefieldsOfWar = 54,
    SwordOfAncestors = 55,
    CosmicArts = 56,
    ShadowArchive = 57,
    ShadowArchivePlus = 58,
    BeastsClaw = 59,
    BoneFist = 60,
    ProudFang = 61,
    SkillAndCrossbones = 62,
    LuckyRing = 63,
    FullBloom = 64,
    DrawRing = 65,
    FullBloomPlus = 66,
    ElvenBandanna = 67,
    DivineBandanna = 68,
    PowerBand = 69,
    BusterBand = 70,
    AntiFormDummy = 71,
    Scimitar = 72,
    WayOfDawn = 73,
    IdentityDisk = 74,
    MagesStaff = 75,
    ProtectBelt = 78,
    GaiaBelt = 79,
    FakeSwordOfAncestors = 80,
    FakeKeyblade = 81,
    Guard = 82,
    MagnetElement = 87,
    ReflectElement = 88,
    NavigationalMap = 89,
    CastleMap = 90,
    BasementMap = 91,
    CastleWallsMap = 92,
    HighJumpLv1 = 94,
    HighJumpLv2 = 95,
    HighJumpLv3 = 96,
    HighJumpMax = 97,
    QuickRunLv1 = 98,
    QuickRunLv2 = 99,
    QuickRunLv3 = 100,
    QuickRunMax = 101,
    AerialDodgeLv1 = 102,
    AerialDodgeLv2 = 103,
    AerialDodgeLv3 = 104,
    AerialDodgeMax = 105,
    GlideLv1 = 106,
    GlideLv2 = 107,
    GlideLv3 = 108,
    GlideMax = 109,
    CosmicBelt = 111,
    EncampmentAreaMap = 112,
    VillageAreaMap = 113,
    CornerstoneHillMap = 114,

    // TODO: Find out the difference between 1 and 2.
    WindowOfTimeMap1 = 115,
    LilliputMap = 116,
    BuildingSiteMap = 117,
    MickeysHouseMap = 118,
    DisneyCastleMap = 119,
    AgrabahMap = 120,
    CaveOfWondersMap = 121,
    RuinsMap = 122,
    UnderseaKingdomMap = 123,
    StarryHillMap = 124,
    OneHundredAcreWoodMap = 125,
    RabbitsHowseMap = 126,
    PiglettsHowseMap = 127,
    KangasHowseMap = 128,
    SpookyCaveMap = 129,
    PalaceMap = 130,
    Tent = 131,
    ShockCharm = 132,
    ShockCharmPlus = 133,
    ColiseumMap = 134,
    UnderworldMap = 135,
    CavernsMap = 136,
    UpperSlash = 137,
    Scan = 138,
    AdamantShield = 139,
    ChainShield = 140,
    OgreShield = 141,
    FallingStar = 142,
    DreamCloud = 143,
    KnightDefender = 144,
    GenjiShield = 145,
    AkashicRecord = 146,
    NobodyGuard = 147,
    HammerStaff = 148,
    VictoryBell = 149,
    MeteorStaff = 150,
    CometStaff = 151,
    LordsBroom = 152,
    WisdomWand = 153,
    RisingDragon = 154,
    NobodyLance = 155,
    ShamansRelic = 156,
    GrandRibbon = 157,
    AerialRecovery = 158,
    LampCharm = 159,
    FeatherCharm = 160,
    StaffOfDetection = 161,
    ComboPlus = 162,
    AirComboPlus = 163,
    DonaldFire = 165,
    DonaldBlizzard = 166,
    DonaldThunder = 167,
    DonaldCure = 168,
    FireBangle = 173,
    FiraBangle = 174,
    HealingWater = 176,
    FuriousShout = 177,
    CurePotion = 187,
    HealingHerb = 190,
    Slow3 = 195,
    FiragaBangle = 197,
    TrinityLimit = 198,
    Fantasia = 199,
    FlareForce = 200,
    TornadoFusion = 201,
    Teamwork = 202,
    TrickFantasy = 203,
    Overdrive = 204,
    HowlingMoon = 205,
    ApplauseApplause = 206,
    Dragonblase = 207,
    EternalSession = 208,
    KingsPride = 209,
    TreasureIsle = 210,
    CompleteCompilement = 211,
    PulsingThunder = 215,
    BraveShot = 216,
    BraveBeat = 217,
    SonicStrike = 218,
    SonicEnd = 219,
    WisdomShot = 220,
    MobileAction = 221,
    SynchBlade = 223,
    MagicHaste = 224,
    MagicSpice = 225,
    SecretAnsemsReport1 = 226,
    SecretAnsemsReport2 = 227,
    SecretAnsemsReport3 = 228,
    SecretAnsemsReport4 = 229,
    SecretAnsemsReport5 = 230,
    SecretAnsemsReport6 = 231,
    SecretAnsemsReport7 = 232,
    SecretAnsemsReport8 = 233,
    SecretAnsemsReport9 = 234,
    SecretAnsemsReport10 = 235,
    SecretAnsemsReport11 = 236,
    SecretAnsemsReport12 = 237,
    SecretAnsemsReport13 = 238,
    OverTheHorizon = 246,
    OmegaFinale = 247,
    ReflectDummy = 248,
    UpperDummy = 249,
    HalloweenTownMap = 250,
    NavalMap = 251,
    PrideRockMap = 252,
    MarketplaceMap = 253,
    PitCellAreaMap = 254,
    TwilightTownMap = 255,
    DarkCityMap = 256,
    MasterStrike = 257,
    Disaster = 258,
    EndlessMagic = 259,
    MasterMagic = 261,
    Slapshot = 262,
    DodgeSlash = 263,
    SlideDash = 264,
    GuardBreak = 265,
    Explosion = 266,
    FinishingLeap = 267,
    Counterguard = 268,
    AerialSweep = 269,
    AerialSpiral = 270,
    HorizontalSlash = 271,
    AerialFinish = 272,
    RetaliatingSlash = 273,
    DriveRecovery = 274,
    HighDriveRecovery = 275,
    PowerBoost = 276,
    MagicBoost = 277,
    DefenseBoost = 278,
    ApBoost = 279,
    DarkShard = 280,
    DarkStone = 281,
    DarkGem = 282,
    DarkCrystal = 283,
    FiragunBangle = 284,
    BlizzardArmlet = 286,
    BlizzaraArmlet = 287,
    BlizzagaArmlet = 288,
    BlizzagunArmlet = 289,
    ThunderTrinket = 291,
    ThundaraTrinket = 292,
    ThundagaTrinket = 293,
    ThundagunTrinket = 294,
    ShadowAnklet = 296,
    DarkAnklet = 297,
    MidnightAnklet = 298,
    ChaosAnklet = 299,
    AbasChain = 301,
    AegisChain = 302,
    Acrisius = 303,
    Ribbon = 304,
    ChampionBelt = 305,
    PetitRibbon = 306,
    AcrisiusPlus = 307,
    CosmicChain = 308,
    BlazingShard = 317,
    BlazingStone = 318,
    BlazingGem = 319,
    BlazingCrystal = 320,
    LightningShard = 325,
    LightningStone = 326,
    LightningGem = 327,
    LightningCrystal = 328,
    PowerShard = 329,
    PowerStone = 330,
    PowerGem = 331,
    PowerCrystal = 332,
    LucidShard = 333,
    LucidStone = 334,
    LucidGem = 335,
    LucidCrystal = 336,
    DenseShard = 337,
    DenseStone = 338,
    DenseGem = 339,
    DenseCrystal = 340,
    TwilightShard = 341,
    TwilightStone = 342,
    TwilightGem = 343,
    TwilightCrystal = 344,
    MythrilShard = 345,
    MythrilStone = 346,
    MythrilGem = 347,
    MythrilCrystal = 348,
    BrightShard = 349,
    BrightStone = 350,
    BrightGem = 351,
    BrightCrystal = 352,
    EnergyShard = 353,
    EnergyStone = 354,
    EnergyGem = 355,
    EnergyCrystal = 356,
    SerenityShard = 357,
    SerenityStone = 358,
    SerenityGem = 359,
    SerenityCrystal = 360,
    OrichalcumPlus = 361,
    OletteMunnyPouch = 362,
    CrystalOrb = 363,
    SeifersTrophy = 364,
    TournamentPoster = 365,
    Poster = 366,
    Letter = 367,
    NaminesSketches = 368,
    MembershipCard = 369,
    OlympusStone = 370,
    AuronsStatue = 371,
    CursedMedallion = 372,
    Present = 373,
    DecoyPresents = 374,
    IceCream = 375,
    Picture = 376,
    Orichalcum = 377,
    FrostShard = 378,
    FrostStone = 379,
    FrostGem = 380,
    FrostCrystal = 381,
    MegaRecipe = 382,
    BaseballCharm = 383,
    StruggleSword = 384,
    AutoValor = 385,
    AutoWisdom = 386,
    AutoMaster = 387,
    AutoFinal = 388,
    AutoSummon = 389,
    ComboBoost = 390,
    AirComboBoost = 391,
    ReactionBoost = 392,
    FinishingPlus = 393,
    NegativeCombo = 394,
    BerserkCharge = 395,
    DamageDrive = 396,
    DriveBoost = 397,
    FormBoost = 398,
    SummonBoost = 399,
    CombinationBoost = 400,
    ExperienceBoost = 401,
    LeafBracer = 402,
    MagicLockOn = 403,
    NoExperience = 404,
    Draw = 405,
    Jackpot = 406,
    LuckyLucky = 407,
    FireBoost = 408,
    BlizzardBoost = 409,
    ThunderBoost = 410,
    ItemBoost = 411,
    MpRage = 412,
    MpHaste = 413,
    Defender = 414,
    SecondChance = 415,
    OnceMore = 416,
    AutoLimit = 417,
    AutoChange = 418,
    HyperHealing = 419,
    AutoHealing = 420,
    MpHastera = 421,
    MpHastega = 422,
    GoofyTornado = 423,
    GoofyTurbo = 425,
    SlashFrenzy = 426,
    Quickplay = 427,
    Divider = 428,
    GoofyBash = 429,
    FerociousRush = 430,
    BlazingFury = 431,
    IcyTerror = 432,
    BoltsOfSorrow = 433,
    MushuFire = 434,
    Flametongue = 435,
    DarkShield = 436,
    DarkAura = 438,
    FierceClaw = 439,
    Groundshaker = 440,
    ScoutingDisk = 444,
    Slow2 = 445,
    NoMercy = 446,
    RainStorm = 447,
    BoneSmash = 448,
    StarRecipe = 449,
    RecoveryRecipe = 450,
    SkillRecipe = 451,
    GuardRecipe = 452,
    Dummy06 = 453,
    Dummy07 = 454,
    Dummy08 = 455,
    Dummy09 = 456,
    Dummy10 = 457,
    Dummy11 = 458,
    Dummy12 = 459,
    Dummy13 = 460,
    Dummy14 = 461,
    Dummy15 = 462,
    Dummy16 = 463,
    RoadtoDiscovery = 464,
    StrengthBeyondStrength = 465,
    BookOfShadows = 466,
    CloakedThunder = 467,
    EternalBlossom = 468,
    RareDocument = 469,
    Dummy23 = 470,
    Dummy24 = 471,
    Dummy25 = 472,
    Dummy26 = 473,
    Dummy27 = 474,
    StyleRecipe = 475,
    MoonRecipe = 476,
    QueenRecipe = 477,
    KingRecipe = 478,
    UltimateRecipe = 479,
    StarSeeker = 480,
    HiddenDragon = 481,
    SaveTheQueen = 482,
    SaveTheKing = 483,
    HerosCrest = 484,
    Monochrome = 485,
    FollowTheWind = 486,
    CircleOfLife = 487,
    PhotonDebugger = 488,
    GullWing = 489,
    RumblingRose = 490,
    GuardianSoul = 491,
    WishingLamp = 492,
    DecisivePumpkin = 493,
    SleepingLion = 494,
    SweetMemories = 495,
    MysteriousAbyss = 496,
    FatalCrest = 497,
    BondOfFlame = 498,
    Fenrir = 499,
    UltimaWeapon = 500,
    StruggleWand = 501,
    StruggleHammer = 502,
    SaveTheQueenPlus = 503,
    SaveTheKingPlus = 504,
    TheInterceptorMap = 505,
    TheBlackPearlMap = 506,
    IslaDeMuertaMap = 507,
    ShipGraveyardMap = 508,
    ChristmasTownMap = 509,
    CurlyHillMap = 510,
    OasisMap = 511,
    SavannahMap = 512,
    CastlePerimeterMap = 513,
    TheGreatMawMap = 514,
    IoTowerMap = 515,
    CentralComputerCoreMap = 516,
    SolarSailerSimulationMap = 517,
    WindowOfTimeMap2 = 518,
    AutoAssault = 519,
    FinishingBlast = 520,
    ComboUpper = 521,
    AerialImpulse = 522,
    RetaliatingSmash = 523,
    PromiseCharm = 524,
    RunningTackle = 525,
    Dash = 526,
    FinalArcana = 527,
    FinalStrike = 528,
    FinalArts = 529,
    CrimeAndPunishment = 530,
    SunsetHillMap = 531,
    MansionMap = 532,
    TowerMap = 533,
    DhMap = 534,
    MickeyMunnyPouch = 535,
    CastleThatNeverWasMap = 536,
    HadesCupTrophy = 537,
    TheStruggleTrophy = 538,
    ComboMaster = 539,
    DriveConverter = 540,
    LightAndDarkness = 541,
    DamageControl = 542,
    TwoBecomeOne = 543,
    WinnersProof = 544,
    Centurion = 545,
    CenturionPlus = 546,
    PlainMushroom = 547,
    PlainMushroomPlus = 548,
    PreciousMushroom = 549,
    PreciousMushroomPlus = 550,
    PremiumMushroom = 551,
    FrozenPride = 552,
    FrozenPridePlus = 553,
    JoyousMushroom = 554,
    JoyousMushroomPlus = 555,
    MajesticMushroom = 556,
    MajesticMushroomPlus = 557,
    UltimateMushroom = 558,
    FlashStep = 559,
    AerialDive = 560,
    MagnetBurst = 561,
    VicinityBreak = 562,
    LimitForm = 563,
    DodgeRollLv1 = 564,
    DodgeRollLv2 = 565,
    DodgeRollLv3 = 566,
    DodgeRollMax = 567,
    AutoLimitForm = 568,
    SonicBlade = 569,
    LastArcanum = 570,
    StrikeRaid = 571,
    Ragnarok = 572,
    Zantetsuken = 573,
    RippleDrive = 574,
    HurricanePeriod = 575,
    RemembranceShard = 576,
    RemembranceStone = 577,
    RemembranceGem = 578,
    RemembranceCrystal = 579,
    TranquilityShard = 580,
    TranquilityStone = 581,
    TranquilityGem = 582,
    TranquilityCrystal = 583,
    LostIllusion = 584,
    ManifestIllusion = 585,
    DarkRemembranceMap = 586,
    ZantetsuCounter = 587,
    ReflectCombo = 588,
    HpGain = 589,
    DepthsOfRemembranceMap = 590,
    GardenOfAssemblageMap = 592,
    ProofOfConnection = 593,
    ProofOfNonexistence = 594,
    ProofOfPeace = 595,
    Protect = 596,
    Protectra = 597,
    Protectga = 598,
    ExecutivesRing = 599,
    ShamansRelicPlus = 600,
    AkashicRecordPlus = 601,
}
