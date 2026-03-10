
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GuestCharacter {
    [ProtoMember(1)]
    public required int characterId { get; set; }

    [ProtoMember(2)]
    public required int guestCharacterId { get; set; }

    [ProtoMember(3)]
    public required int hp { get; set; }

    [ProtoMember(5)]
    public required int? dishId { get; set; }

    [ProtoMember(6)]
    public required int dishEffectCount { get; set; }

    [ProtoMember(7)]
    public required DateTime? dishEffectExpiredAt { get; set; }

    [ProtoMember(8)]
    public required DateTime? joinedAt { get; set; }

    [ProtoMember(9)]
    public required int attack { get; set; }

    [ProtoMember(10)]
    public required int defense { get; set; }

    [ProtoMember(11)]
    public required int maxHp { get; set; }

    [ProtoMember(12)]
    public required float criticalRate { get; set; }

    [ProtoMember(13)]
    public required float criticalDamageRate { get; set; }

    [ProtoMember(14)]
    public required int supportPowerRate { get; set; }

    [ProtoMember(15)]
    public required float movementSpeed { get; set; }

    [ProtoMember(16)]
    public required float powerRate { get; set; }

    [ProtoMember(17)]
    public required float dodgeSpeed { get; set; }

    [ProtoMember(18)]
    public required float damageInflictedRate { get; set; }

    [ProtoMember(19)]
    public required float tensionIncreaseRate { get; set; }

    [ProtoMember(20)]
    public required float cpRecastRate { get; set; }

    [ProtoMember(21)]
    public required float recoveryGivenRate { get; set; }

    [ProtoMember(22)]
    public required float spGaugeIncreaseRate { get; set; }

    [ProtoMember(23)]
    public required float attackSpeed { get; set; }

    [ProtoMember(24)]
    public required AbnormalityParamSet abnormalityParamSet { get; set; }

    [ProtoMember(25)]
    public required int actionPointMax { get; set; }

    [ProtoMember(26)]
    public required float actionPointRate { get; set; }

    [ProtoMember(27)]
    public required float actionPointConsumption { get; set; }

    [ProtoMember(29)]
    public required int trainingScore { get; set; }

    [ProtoMember(30)]
    public required int trainingScoreLevelScore { get; set; }

    [ProtoMember(31)]
    public required int trainingScoreRankScore { get; set; }

    [ProtoMember(32)]
    public required float damageTakenRate { get; set; }

}