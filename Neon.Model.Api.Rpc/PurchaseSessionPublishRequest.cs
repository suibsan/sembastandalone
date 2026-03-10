
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseSessionPublishRequest {
    [ProtoMember(1)]
    public required string purchaseSessionId { get; set; }

    [ProtoMember(2)]
    public required string eventType { get; set; }

    [ProtoMember(3)]
    public required string transactionId { get; set; }

    [ProtoMember(4)]
    public required string productId { get; set; }

    [ProtoMember(5)]
    public required string clientCurrency { get; set; }

    [ProtoMember(6)]
    public required double? clientPrice { get; set; }

    [ProtoMember(7)]
    public required string purchaseData { get; set; }

    [ProtoMember(8)]
    public required string dataSignature { get; set; }

    [ProtoMember(9)]
    public required string receipt { get; set; }

    [ProtoMember(10)]
    public required string failureReason { get; set; }

}