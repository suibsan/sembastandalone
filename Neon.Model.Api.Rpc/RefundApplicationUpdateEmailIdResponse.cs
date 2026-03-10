
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationUpdateEmailIdResponse {
    [ProtoMember(1)]
    public RefundApplication refundApplication { get; set; }

}