
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundDestinationPaypal {
    [ProtoMember(1)]
    public bool useVerifiedEmail { get; set; }

    [ProtoMember(2)]
    public string emailId { get; set; }

}