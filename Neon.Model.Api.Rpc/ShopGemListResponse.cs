
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopGemListResponse {
    [ProtoMember(1)]
    public ShopProduct[] shopProducts { get; set; }

    [ProtoMember(2)]
    public StoreProduct[] storeProducts { get; set; }

    [ProtoMember(3)]
    public int monthlyBillingAmount { get; set; }

}