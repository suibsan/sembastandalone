
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopGemListResponse {
    [ProtoMember(1)]
    public required ShopProduct[] shopProducts { get; set; }

    [ProtoMember(2)]
    public required StoreProduct[] storeProducts { get; set; }

    [ProtoMember(3)]
    public required int monthlyBillingAmount { get; set; }

}