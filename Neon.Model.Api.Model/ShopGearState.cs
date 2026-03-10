
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopGearState {
    [ProtoMember(1)]
    public int shopId { get; set; }

    [ProtoMember(2)]
    public DateTime? refreshAt { get; set; }

    [ProtoMember(3)]
    public ShopGearPurchaseState[] purchaseStates { get; set; }

}