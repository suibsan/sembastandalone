
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationGetResponse {
    [ProtoMember(1)]
    public required RefundApplication refundApplication { get; set; }

    [ProtoMember(2)]
    public required string profileName { get; set; }

    [ProtoMember(3)]
    public required RefundPurchase refundPurchase { get; set; }

    [ProtoMember(4)]
    public required RefundPaidGem refundPaidGem { get; set; }

}