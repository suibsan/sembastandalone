
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseHistoryResponse {
    [ProtoMember(1)]
    public required PurchaseHistory[] histories { get; set; }

}