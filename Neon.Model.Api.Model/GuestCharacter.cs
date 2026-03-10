
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GuestCharacter {
    [ProtoMember(1)]
    public int characterId { get; set; }

    [ProtoMember(2)]
    public int guestCharacterId { get; set; }

    [ProtoMember(3)]
    public int hp { get; set; }

    [ProtoMember(5)]
    public int? dishId { get; set; }

    [ProtoMember(6)]
    public int dishEffectCount { get; set; }

    [ProtoMember(7)]
    public DateTime? dishEffectExpiredAt { get; set; }

    [ProtoMember(8)]
    public DateTime? joinedAt { get; set; }

    [ProtoMember(9)]
    public int attack { get; set; }

    [ProtoMember(10)]
    public int defense { get; set; }

    [ProtoMember(11)]
    public int maxHp { get; set; }

    [ProtoMember(12)]
    public float criticalRate { get; set; }

    [ProtoMember(13)]
    public float criticalDamageRate { get; set; }

    [ProtoMember(14)]
    public int supportPowerRate { get; set; }

    [ProtoMember(15)]
    public float movementSpeed { get; set; }

    [ProtoMember(16)]
    public float powerRate { get; set; }

    [ProtoMember(17)]
    public float dodgeSpeed { get; set; }

    [ProtoMember(18)]
    public float damageInflictedRate { get; set; }

    [ProtoMember(19)]
    public float tensionIncreaseRate { get; set; }

    [ProtoMember(20)]
    public float cpRecastRate { get; set; }

    [ProtoMember(21)]
    public float recoveryGivenRate { get; set; }

    [ProtoMember(22)]
    public float spGaugeIncreaseRate { get; set; }

    [ProtoMember(23)]
    public float attackSpeed { get; set; }

    [ProtoMember(24)]
    public AbnormalityParamSet abnormalityParamSet { get; set; }

    [ProtoMember(25)]
    public int actionPointMax { get; set; }

    [ProtoMember(26)]
    public float actionPointRate { get; set; }

    [ProtoMember(27)]
    public float actionPointConsumption { get; set; }

    [ProtoMember(29)]
    public int trainingScore { get; set; }

    [ProtoMember(30)]
    public int trainingScoreLevelScore { get; set; }

    [ProtoMember(31)]
    public int trainingScoreRankScore { get; set; }

    [ProtoMember(32)]
    public float damageTakenRate { get; set; }

}