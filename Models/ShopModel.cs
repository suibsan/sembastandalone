
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class ShopModel {

public static ChangedResourcesResponse? Shop_CycleUpdateShopPurchase(ShopCycleUpdateShopPurchaseRequest req) {
    Console.WriteLine($"Shop_CycleUpdateShopPurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/cycle_update_shop_purchase", req.ToString())
    );
}


public static ChangedResourcesResponse? Shop_CycleUpdateShopRelease(ShopCycleUpdateShopReleaseRequest req) {
    Console.WriteLine($"Shop_CycleUpdateShopRelease: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/cycle_update_shop_release", req.ToString())
    );
}


public static ShopGearShopListResponse? Shop_GearShopList(ShopGearShopListRequest req) {
    Console.WriteLine($"Shop_GearShopList: {req}");
    return ShopGearShopListResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/gear_shop_list", req.ToString())
    );
}


public static ShopGearShopPurchaseResponse? Shop_GearShopPurchase(ShopGearShopPurchaseRequest req) {
    Console.WriteLine($"Shop_GearShopPurchase: {req}");
    return ShopGearShopPurchaseResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/gear_shop_purchase", req.ToString())
    );
}


public static ShopGemListResponse? Shop_GemList() {
    // no request
    return ShopGemListResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/gem_list", "")
    );
}


public static ChangedResourcesResponse? Shop_Purchase(ShopPurchaseRequest req) {
    Console.WriteLine($"Shop_Purchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/purchase", req.ToString())
    );
}


public static ShopRandomCostumeListResponse? Shop_RandomCostumeList(ShopRandomCostumeListRequest req) {
    Console.WriteLine($"Shop_RandomCostumeList: {req}");
    return ShopRandomCostumeListResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/random_costume_list", req.ToString())
    );
}


public static ChangedResourcesResponse? Shop_RandomCostumePurchase(ShopRandomCostumePurchaseRequest req) {
    Console.WriteLine($"Shop_RandomCostumePurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/shop/random_costume_purchase", req.ToString())
    );
}

}
