
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseSessionStartResponse {
    [ProtoMember(1)]
    public required string purchaseSessionId { get; set; }

    [ProtoMember(2)]
    public required string transactionId { get; set; }

}