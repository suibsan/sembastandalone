
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Attack {
    [ProtoMember(1)]
    public int id { get; set; }

    [ProtoMember(3)]
    public float powerMultiply { get; set; }

    [ProtoMember(4)]
    public float hitbackDistance { get; set; }

    [ProtoMember(5)]
    public float attackerHitSlowTime { get; set; }

    [ProtoMember(6)]
    public float attackerHitSlowSpeed { get; set; }

    [ProtoMember(7)]
    public float defenderHitSlowTime { get; set; }

    [ProtoMember(8)]
    public float defenderHitSlowSpeed { get; set; }

    [ProtoMember(9)]
    public float hitInterval { get; set; }

    [ProtoMember(10)]
    public int blowUpParameterMasterId { get; set; }

    [ProtoMember(11)]
    public int? hitConditionSkillId { get; set; }

    [ProtoMember(14)]
    public int[] attackAttributes { get; set; }

}