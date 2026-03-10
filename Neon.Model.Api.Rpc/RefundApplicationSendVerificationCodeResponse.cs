
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationSendVerificationCodeResponse {
    [ProtoMember(1)]
    public DateTime? cooldownAt { get; set; }

}