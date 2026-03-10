
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AbnormalityParam {
    [ProtoMember(1)]
    public float attackRate { get; set; }

    [ProtoMember(2)]
    public float defenseRate { get; set; }

    [ProtoMember(3)]
    public float burstResistance { get; set; }

    [ProtoMember(4)]
    public float burstResistanceLimit { get; set; }

    [ProtoMember(5)]
    public float burstResistanceIncreaseValue { get; set; }

}