
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AbnormalityParam {
    [ProtoMember(1)]
    public required float attackRate { get; set; }

    [ProtoMember(2)]
    public required float defenseRate { get; set; }

    [ProtoMember(3)]
    public required float burstResistance { get; set; }

    [ProtoMember(4)]
    public required float burstResistanceLimit { get; set; }

    [ProtoMember(5)]
    public required float burstResistanceIncreaseValue { get; set; }

}