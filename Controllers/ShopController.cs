
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class ShopController : Controller {

private ShopModel model;

public ShopController(ISembaWrapper wrapper) {
    model = new ShopModel(wrapper);
}


[Route("/shop/cycle_update_shop_purchase")]
public async Task<IActionResult> Shop_CycleUpdateShopPurchase() {
    var req = await RequestSerializer.Deserialize<ShopCycleUpdateShopPurchaseRequest>(Request);

    var res = model.Shop_CycleUpdateShopPurchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/shop/cycle_update_shop_release")]
public async Task<IActionResult> Shop_CycleUpdateShopRelease() {
    var req = await RequestSerializer.Deserialize<ShopCycleUpdateShopReleaseRequest>(Request);

    var res = model.Shop_CycleUpdateShopRelease(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/shop/gear_shop_list")]
public async Task<IActionResult> Shop_GearShopList() {
    var req = await RequestSerializer.Deserialize<ShopGearShopListRequest>(Request);

    var res = model.Shop_GearShopList(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/shop/gear_shop_purchase")]
public async Task<IActionResult> Shop_GearShopPurchase() {
    var req = await RequestSerializer.Deserialize<ShopGearShopPurchaseRequest>(Request);

    var res = model.Shop_GearShopPurchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/shop/gem_list")]
public IActionResult Shop_GemList() {
    // no request

    var res = model.Shop_GemList();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/shop/purchase")]
public async Task<IActionResult> Shop_Purchase() {
    var req = await RequestSerializer.Deserialize<ShopPurchaseRequest>(Request);

    var res = model.Shop_Purchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/shop/random_costume_list")]
public async Task<IActionResult> Shop_RandomCostumeList() {
    var req = await RequestSerializer.Deserialize<ShopRandomCostumeListRequest>(Request);

    var res = model.Shop_RandomCostumeList(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/shop/random_costume_purchase")]
public async Task<IActionResult> Shop_RandomCostumePurchase() {
    var req = await RequestSerializer.Deserialize<ShopRandomCostumePurchaseRequest>(Request);

    var res = model.Shop_RandomCostumePurchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
