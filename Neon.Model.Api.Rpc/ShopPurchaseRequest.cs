
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopPurchaseRequest {
    [ProtoMember(1)]
    public int shopProductId { get; set; }

    [ProtoMember(2)]
    public int quantity { get; set; }

}