
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundDestinationWise {
    [ProtoMember(1)]
    public required bool useVerifiedEmail { get; set; }

    [ProtoMember(2)]
    public required string emailId { get; set; }

}