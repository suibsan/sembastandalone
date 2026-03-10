
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Character {
    [ProtoMember(1)]
    public required int characterId { get; set; }

    [ProtoMember(2)]
    public required int exp { get; set; }

    [ProtoMember(3)]
    public required int limitBreak { get; set; }

    [ProtoMember(4)]
    public required int hp { get; set; }

    [ProtoMember(5)]
    public required int attack { get; set; }

    [ProtoMember(6)]
    public required int defense { get; set; }

    [ProtoMember(7)]
    public required int maxHp { get; set; }

    [ProtoMember(9)]
    public required int? gearSlot1 { get; set; }

    [ProtoMember(10)]
    public required int? gearSlot2 { get; set; }

    [ProtoMember(11)]
    public required int? gearSlot3 { get; set; }

    [ProtoMember(20)]
    public required DateTime? receivedAt { get; set; }

    [ProtoMember(21)]
    public required int characterOwnershipType { get; set; }

    [ProtoMember(23)]
    public required int? dishId { get; set; }

    [ProtoMember(24)]
    public required int dishEffectCount { get; set; }

    [ProtoMember(25)]
    public required DateTime? dishEffectExpiredAt { get; set; }

    [ProtoMember(26)]
    public required int rank { get; set; }

    [ProtoMember(27)]
    public required float criticalRate { get; set; }

    [ProtoMember(28)]
    public required float criticalDamageRate { get; set; }

    [ProtoMember(30)]
    public required int supportPowerRate { get; set; }

    [ProtoMember(40)]
    public required float movementSpeed { get; set; }

    [ProtoMember(41)]
    public required float powerRate { get; set; }

    [ProtoMember(42)]
    public required float dodgeSpeed { get; set; }

    [ProtoMember(43)]
    public required float damageInflictedRate { get; set; }

    [ProtoMember(44)]
    public required float tensionIncreaseRate { get; set; }

    [ProtoMember(45)]
    public required float cpRecastRate { get; set; }

    [ProtoMember(46)]
    public required float recoveryGivenRate { get; set; }

    [ProtoMember(47)]
    public required float spGaugeIncreaseRate { get; set; }

    [ProtoMember(48)]
    public required float attackSpeed { get; set; }

    [ProtoMember(49)]
    public required int? characterCostumeId { get; set; }

    [ProtoMember(53)]
    public required int characterSkillPanel1Level { get; set; }

    [ProtoMember(54)]
    public required int characterSkillPanel2Level { get; set; }

    [ProtoMember(55)]
    public required int characterSkillPanel3Level { get; set; }

    [ProtoMember(56)]
    public required int characterSkillPanel4Level { get; set; }

    [ProtoMember(57)]
    public required int characterSkillPanel5Level { get; set; }

    [ProtoMember(59)]
    public required AbnormalityParamSet abnormalityParamSet { get; set; }

    [ProtoMember(61)]
    public required int trainingScore { get; set; }

    [ProtoMember(62)]
    public required int trainingScoreLevelScore { get; set; }

    [ProtoMember(63)]
    public required int trainingScoreRankScore { get; set; }

    [ProtoMember(64)]
    public required int actionPointMax { get; set; }

    [ProtoMember(65)]
    public required float actionPointRate { get; set; }

    [ProtoMember(66)]
    public required float actionPointConsumption { get; set; }

    [ProtoMember(67)]
    public required float damageTakenRate { get; set; }

}