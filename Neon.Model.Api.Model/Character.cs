
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Character {
    [ProtoMember(1)]
    public int characterId { get; set; }

    [ProtoMember(2)]
    public int exp { get; set; }

    [ProtoMember(3)]
    public int limitBreak { get; set; }

    [ProtoMember(4)]
    public int hp { get; set; }

    [ProtoMember(5)]
    public int attack { get; set; }

    [ProtoMember(6)]
    public int defense { get; set; }

    [ProtoMember(7)]
    public int maxHp { get; set; }

    [ProtoMember(9)]
    public int? gearSlot1 { get; set; }

    [ProtoMember(10)]
    public int? gearSlot2 { get; set; }

    [ProtoMember(11)]
    public int? gearSlot3 { get; set; }

    [ProtoMember(20)]
    public DateTime? receivedAt { get; set; }

    [ProtoMember(21)]
    public int characterOwnershipType { get; set; }

    [ProtoMember(23)]
    public int? dishId { get; set; }

    [ProtoMember(24)]
    public int dishEffectCount { get; set; }

    [ProtoMember(25)]
    public DateTime? dishEffectExpiredAt { get; set; }

    [ProtoMember(26)]
    public int rank { get; set; }

    [ProtoMember(27)]
    public float criticalRate { get; set; }

    [ProtoMember(28)]
    public float criticalDamageRate { get; set; }

    [ProtoMember(30)]
    public int supportPowerRate { get; set; }

    [ProtoMember(40)]
    public float movementSpeed { get; set; }

    [ProtoMember(41)]
    public float powerRate { get; set; }

    [ProtoMember(42)]
    public float dodgeSpeed { get; set; }

    [ProtoMember(43)]
    public float damageInflictedRate { get; set; }

    [ProtoMember(44)]
    public float tensionIncreaseRate { get; set; }

    [ProtoMember(45)]
    public float cpRecastRate { get; set; }

    [ProtoMember(46)]
    public float recoveryGivenRate { get; set; }

    [ProtoMember(47)]
    public float spGaugeIncreaseRate { get; set; }

    [ProtoMember(48)]
    public float attackSpeed { get; set; }

    [ProtoMember(49)]
    public int? characterCostumeId { get; set; }

    [ProtoMember(53)]
    public int characterSkillPanel1Level { get; set; }

    [ProtoMember(54)]
    public int characterSkillPanel2Level { get; set; }

    [ProtoMember(55)]
    public int characterSkillPanel3Level { get; set; }

    [ProtoMember(56)]
    public int characterSkillPanel4Level { get; set; }

    [ProtoMember(57)]
    public int characterSkillPanel5Level { get; set; }

    [ProtoMember(59)]
    public AbnormalityParamSet abnormalityParamSet { get; set; }

    [ProtoMember(61)]
    public int trainingScore { get; set; }

    [ProtoMember(62)]
    public int trainingScoreLevelScore { get; set; }

    [ProtoMember(63)]
    public int trainingScoreRankScore { get; set; }

    [ProtoMember(64)]
    public int actionPointMax { get; set; }

    [ProtoMember(65)]
    public float actionPointRate { get; set; }

    [ProtoMember(66)]
    public float actionPointConsumption { get; set; }

    [ProtoMember(67)]
    public float damageTakenRate { get; set; }

}