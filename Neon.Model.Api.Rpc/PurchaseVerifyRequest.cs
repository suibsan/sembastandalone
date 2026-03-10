
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseVerifyRequest {
    [ProtoMember(1)]
    public required string purchaseSessionId { get; set; }

    [ProtoMember(2)]
    public required string transactionId { get; set; }

    [ProtoMember(3)]
    public required string clientCurrency { get; set; }

    [ProtoMember(4)]
    public required double? clientPrice { get; set; }

    [ProtoMember(5)]
    public required string purchaseData { get; set; }

    [ProtoMember(6)]
    public required string dataSignature { get; set; }

}