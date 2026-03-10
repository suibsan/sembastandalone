
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplication {
    [ProtoMember(3)]
    public string verifiedEmailId { get; set; }

    [ProtoMember(1)]
    public DateTime? emailIdVerifiedAt { get; set; }

    [ProtoMember(2)]
    public DateTime? acceptedAt { get; set; }

}