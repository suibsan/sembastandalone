
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopCycleUpdateShopPurchaseRequest {
    [ProtoMember(1)]
    public required int cycleUpdateShopId { get; set; }

    [ProtoMember(2)]
    public required DateTime? clientTimestamp { get; set; }

}