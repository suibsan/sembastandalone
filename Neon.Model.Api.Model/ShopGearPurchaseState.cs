
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopGearPurchaseState {
    [ProtoMember(1)]
    public int shopGearProductId { get; set; }

    [ProtoMember(2)]
    public int[] subGearStatusIds { get; set; }

    [ProtoMember(3)]
    public int count { get; set; }

}