
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseVerifyRequest {
    [ProtoMember(1)]
    public string purchaseSessionId { get; set; }

    [ProtoMember(2)]
    public string transactionId { get; set; }

    [ProtoMember(3)]
    public string clientCurrency { get; set; }

    [ProtoMember(4)]
    public double? clientPrice { get; set; }

    [ProtoMember(5)]
    public string purchaseData { get; set; }

    [ProtoMember(6)]
    public string dataSignature { get; set; }

}