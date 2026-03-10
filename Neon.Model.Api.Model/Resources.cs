
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Resources {
    [ProtoMember(38)]
    public AdventureVariable[] adventureVariables { get; set; }

    [ProtoMember(16)]
    public Area[] areas { get; set; }

    [ProtoMember(35)]
    public AreaChangeLock[] areaChangeLocks { get; set; }

    [ProtoMember(29)]
    public AreaGroup[] areaGroups { get; set; }

    [ProtoMember(42)]
    public AreaObjectLock[] areaObjectLocks { get; set; }

    [ProtoMember(12)]
    public Challenge[] challenges { get; set; }

    [ProtoMember(13)]
    public ChallengeProgress[] challengeProgresses { get; set; }

    [ProtoMember(14)]
    public ChallengeTask[] challengeTasks { get; set; }

    [ProtoMember(2)]
    public Character[] characters { get; set; }

    [ProtoMember(23)]
    public CharacterCostume[] characterCostumes { get; set; }

    [ProtoMember(43)]
    public CharacterLikability[] characterLikabilities { get; set; }

    [ProtoMember(9)]
    public CharacterMountingPower[] characterMountingPowers { get; set; }

    [ProtoMember(10)]
    public CharacterMountingPowerCommon characterMountingPowerCommon { get; set; }

    [ProtoMember(6)]
    public CharacterPiece[] characterPieces { get; set; }

    [ProtoMember(19)]
    public City[] cities { get; set; }

    [ProtoMember(32)]
    public CycleUpdateShopState[] cycleUpdateShopStates { get; set; }

    [ProtoMember(45)]
    public DailyPassState[] dailyPassStates { get; set; }

    [ProtoMember(33)]
    public Dungeon[] dungeons { get; set; }

    [ProtoMember(48)]
    public EventFloorNode[] eventFloorNodes { get; set; }

    [ProtoMember(37)]
    public EventLift[] eventLifts { get; set; }

    [ProtoMember(49)]
    public Follow[] follows { get; set; }

    [ProtoMember(8)]
    public Formation[] formations { get; set; }

    [ProtoMember(17)]
    public FractalVise[] fractalVises { get; set; }

    [ProtoMember(3)]
    public Gear[] gears { get; set; }

    [ProtoMember(31)]
    public GraffitiArt[] graffitiArts { get; set; }

    [ProtoMember(41)]
    public GuestCharacter[] guestCharacters { get; set; }

    [ProtoMember(4)]
    public Item[] items { get; set; }

    [ProtoMember(24)]
    public LoginBonus[] loginBonuses { get; set; }

    [ProtoMember(47)]
    public MagicOrb[] magicOrbs { get; set; }

    [ProtoMember(25)]
    public Mission[] missions { get; set; }

    [ProtoMember(30)]
    public MissionCountRewardState[] missionCountRewardStates { get; set; }

    [ProtoMember(21)]
    public NineSequence[] nineSequences { get; set; }

    [ProtoMember(11)]
    public Notifications notifications { get; set; }

    [ProtoMember(34)]
    public Profile profile { get; set; }

    [ProtoMember(36)]
    public ProfileBadge[] profileBadges { get; set; }

    [ProtoMember(39)]
    public ProfileBanner[] profileBanners { get; set; }

    [ProtoMember(44)]
    public QuestState[] questStates { get; set; }

    [ProtoMember(26)]
    public SeasonPass[] seasonPasses { get; set; }

    [ProtoMember(27)]
    public SeasonPassTierState[] seasonPassTierStates { get; set; }

    [ProtoMember(20)]
    public ShopProductState[] shopProductStates { get; set; }

    [ProtoMember(5)]
    public Status status { get; set; }

    [ProtoMember(40)]
    public SynthesisRecipe[] synthesisRecipes { get; set; }

    [ProtoMember(7)]
    public TensionCard[] tensionCards { get; set; }

    [ProtoMember(22)]
    public Tip[] tips { get; set; }

    [ProtoMember(28)]
    public TotalTask[] totalTasks { get; set; }

    [ProtoMember(50)]
    public TrialBattleState[] trialBattleStates { get; set; }

    [ProtoMember(46)]
    public TutorialState[] tutorialStates { get; set; }

    [ProtoMember(1)]
    public Wallet wallet { get; set; }

    [ProtoMember(15)]
    public WarpPoint[] warpPoints { get; set; }

    [ProtoMember(18)]
    public XbStatus[] xbStatuses { get; set; }

}