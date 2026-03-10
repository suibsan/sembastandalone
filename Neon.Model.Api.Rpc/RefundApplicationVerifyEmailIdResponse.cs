
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationVerifyEmailIdResponse {
    [ProtoMember(1)]
    public required RefundApplication refundApplication { get; set; }

}