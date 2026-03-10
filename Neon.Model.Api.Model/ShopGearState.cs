
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopGearState {
    [ProtoMember(1)]
    public required int shopId { get; set; }

    [ProtoMember(2)]
    public required DateTime? refreshAt { get; set; }

    [ProtoMember(3)]
    public required ShopGearPurchaseState[] purchaseStates { get; set; }

}