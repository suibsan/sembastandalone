
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseSessionPublishRequest {
    [ProtoMember(1)]
    public string purchaseSessionId { get; set; }

    [ProtoMember(2)]
    public string eventType { get; set; }

    [ProtoMember(3)]
    public string transactionId { get; set; }

    [ProtoMember(4)]
    public string productId { get; set; }

    [ProtoMember(5)]
    public string clientCurrency { get; set; }

    [ProtoMember(6)]
    public double? clientPrice { get; set; }

    [ProtoMember(7)]
    public string purchaseData { get; set; }

    [ProtoMember(8)]
    public string dataSignature { get; set; }

    [ProtoMember(9)]
    public string receipt { get; set; }

    [ProtoMember(10)]
    public string failureReason { get; set; }

}