
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Attack {
    [ProtoMember(1)]
    public required int id { get; set; }

    [ProtoMember(3)]
    public required float powerMultiply { get; set; }

    [ProtoMember(4)]
    public required float hitbackDistance { get; set; }

    [ProtoMember(5)]
    public required float attackerHitSlowTime { get; set; }

    [ProtoMember(6)]
    public required float attackerHitSlowSpeed { get; set; }

    [ProtoMember(7)]
    public required float defenderHitSlowTime { get; set; }

    [ProtoMember(8)]
    public required float defenderHitSlowSpeed { get; set; }

    [ProtoMember(9)]
    public required float hitInterval { get; set; }

    [ProtoMember(10)]
    public required int blowUpParameterMasterId { get; set; }

    [ProtoMember(11)]
    public required int? hitConditionSkillId { get; set; }

    [ProtoMember(14)]
    public required int[] attackAttributes { get; set; }

}