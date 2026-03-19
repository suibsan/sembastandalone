
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class ShopModel {

public ChangedResourcesResponse? Shop_CycleUpdateShopPurchase(ShopCycleUpdateShopPurchaseRequest req) {
    Console.WriteLine($"Shop_CycleUpdateShopPurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/cycle_update_shop_purchase", req.ToString())
    );
}


public ChangedResourcesResponse? Shop_CycleUpdateShopRelease(ShopCycleUpdateShopReleaseRequest req) {
    Console.WriteLine($"Shop_CycleUpdateShopRelease: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/cycle_update_shop_release", req.ToString())
    );
}


public ShopGearShopListResponse? Shop_GearShopList(ShopGearShopListRequest req) {
    Console.WriteLine($"Shop_GearShopList: {req}");
    return ShopGearShopListResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/gear_shop_list", req.ToString())
    );
}


public ShopGearShopPurchaseResponse? Shop_GearShopPurchase(ShopGearShopPurchaseRequest req) {
    Console.WriteLine($"Shop_GearShopPurchase: {req}");
    return ShopGearShopPurchaseResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/gear_shop_purchase", req.ToString())
    );
}


public ShopGemListResponse? Shop_GemList() {
    // no request
    return ShopGemListResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/gem_list", "")
    );
}


public ChangedResourcesResponse? Shop_Purchase(ShopPurchaseRequest req) {
    Console.WriteLine($"Shop_Purchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/purchase", req.ToString())
    );
}


public ShopRandomCostumeListResponse? Shop_RandomCostumeList(ShopRandomCostumeListRequest req) {
    Console.WriteLine($"Shop_RandomCostumeList: {req}");
    return ShopRandomCostumeListResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/random_costume_list", req.ToString())
    );
}


public ChangedResourcesResponse? Shop_RandomCostumePurchase(ShopRandomCostumePurchaseRequest req) {
    Console.WriteLine($"Shop_RandomCostumePurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/shop/random_costume_purchase", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public ShopModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
