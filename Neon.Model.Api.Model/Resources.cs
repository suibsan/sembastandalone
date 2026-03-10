
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Resources {
    [ProtoMember(38)]
    public required AdventureVariable[] adventureVariables { get; set; }

    [ProtoMember(16)]
    public required Area[] areas { get; set; }

    [ProtoMember(35)]
    public required AreaChangeLock[] areaChangeLocks { get; set; }

    [ProtoMember(29)]
    public required AreaGroup[] areaGroups { get; set; }

    [ProtoMember(42)]
    public required AreaObjectLock[] areaObjectLocks { get; set; }

    [ProtoMember(12)]
    public required Challenge[] challenges { get; set; }

    [ProtoMember(13)]
    public required ChallengeProgress[] challengeProgresses { get; set; }

    [ProtoMember(14)]
    public required ChallengeTask[] challengeTasks { get; set; }

    [ProtoMember(2)]
    public required Character[] characters { get; set; }

    [ProtoMember(23)]
    public required CharacterCostume[] characterCostumes { get; set; }

    [ProtoMember(43)]
    public required CharacterLikability[] characterLikabilities { get; set; }

    [ProtoMember(9)]
    public required CharacterMountingPower[] characterMountingPowers { get; set; }

    [ProtoMember(10)]
    public required CharacterMountingPowerCommon characterMountingPowerCommon { get; set; }

    [ProtoMember(6)]
    public required CharacterPiece[] characterPieces { get; set; }

    [ProtoMember(19)]
    public required City[] cities { get; set; }

    [ProtoMember(32)]
    public required CycleUpdateShopState[] cycleUpdateShopStates { get; set; }

    [ProtoMember(45)]
    public required DailyPassState[] dailyPassStates { get; set; }

    [ProtoMember(33)]
    public required Dungeon[] dungeons { get; set; }

    [ProtoMember(48)]
    public required EventFloorNode[] eventFloorNodes { get; set; }

    [ProtoMember(37)]
    public required EventLift[] eventLifts { get; set; }

    [ProtoMember(49)]
    public required Follow[] follows { get; set; }

    [ProtoMember(8)]
    public required Formation[] formations { get; set; }

    [ProtoMember(17)]
    public required FractalVise[] fractalVises { get; set; }

    [ProtoMember(3)]
    public required Gear[] gears { get; set; }

    [ProtoMember(31)]
    public required GraffitiArt[] graffitiArts { get; set; }

    [ProtoMember(41)]
    public required GuestCharacter[] guestCharacters { get; set; }

    [ProtoMember(4)]
    public required Item[] items { get; set; }

    [ProtoMember(24)]
    public required LoginBonus[] loginBonuses { get; set; }

    [ProtoMember(47)]
    public required MagicOrb[] magicOrbs { get; set; }

    [ProtoMember(25)]
    public required Mission[] missions { get; set; }

    [ProtoMember(30)]
    public required MissionCountRewardState[] missionCountRewardStates { get; set; }

    [ProtoMember(21)]
    public required NineSequence[] nineSequences { get; set; }

    [ProtoMember(11)]
    public required Notifications notifications { get; set; }

    [ProtoMember(34)]
    public required Profile profile { get; set; }

    [ProtoMember(36)]
    public required ProfileBadge[] profileBadges { get; set; }

    [ProtoMember(39)]
    public required ProfileBanner[] profileBanners { get; set; }

    [ProtoMember(44)]
    public required QuestState[] questStates { get; set; }

    [ProtoMember(26)]
    public required SeasonPass[] seasonPasses { get; set; }

    [ProtoMember(27)]
    public required SeasonPassTierState[] seasonPassTierStates { get; set; }

    [ProtoMember(20)]
    public required ShopProductState[] shopProductStates { get; set; }

    [ProtoMember(5)]
    public required Status status { get; set; }

    [ProtoMember(40)]
    public required SynthesisRecipe[] synthesisRecipes { get; set; }

    [ProtoMember(7)]
    public required TensionCard[] tensionCards { get; set; }

    [ProtoMember(22)]
    public required Tip[] tips { get; set; }

    [ProtoMember(28)]
    public required TotalTask[] totalTasks { get; set; }

    [ProtoMember(50)]
    public required TrialBattleState[] trialBattleStates { get; set; }

    [ProtoMember(46)]
    public required TutorialState[] tutorialStates { get; set; }

    [ProtoMember(1)]
    public required Wallet wallet { get; set; }

    [ProtoMember(15)]
    public required WarpPoint[] warpPoints { get; set; }

    [ProtoMember(18)]
    public required XbStatus[] xbStatuses { get; set; }

}