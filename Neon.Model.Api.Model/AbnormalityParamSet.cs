
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AbnormalityParamSet {
    [ProtoMember(1)]
    public AbnormalityParam oily { get; set; }

    [ProtoMember(2)]
    public AbnormalityParam pressure { get; set; }

    [ProtoMember(3)]
    public AbnormalityParam scared { get; set; }

    [ProtoMember(4)]
    public AbnormalityParam electric { get; set; }

    [ProtoMember(5)]
    public AbnormalityParam unfortified { get; set; }

}