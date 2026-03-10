
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AbnormalityParamSet {
    [ProtoMember(1)]
    public required AbnormalityParam oily { get; set; }

    [ProtoMember(2)]
    public required AbnormalityParam pressure { get; set; }

    [ProtoMember(3)]
    public required AbnormalityParam scared { get; set; }

    [ProtoMember(4)]
    public required AbnormalityParam electric { get; set; }

    [ProtoMember(5)]
    public required AbnormalityParam unfortified { get; set; }

}