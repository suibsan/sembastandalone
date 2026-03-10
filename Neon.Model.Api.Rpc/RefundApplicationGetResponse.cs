
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationGetResponse {
    [ProtoMember(1)]
    public RefundApplication refundApplication { get; set; }

    [ProtoMember(2)]
    public string profileName { get; set; }

    [ProtoMember(3)]
    public RefundPurchase refundPurchase { get; set; }

    [ProtoMember(4)]
    public RefundPaidGem refundPaidGem { get; set; }

}