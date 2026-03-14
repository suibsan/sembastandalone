
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class ItemController : Controller {

[Route("/item/exchange")]
public async Task<IActionResult> Item_Exchange() {
    var req = await RequestSerializer.Deserialize<ItemExchangeRequest>(Request);

    var res = ItemModel.Item_Exchange(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item/open_select_box")]
public async Task<IActionResult> Item_OpenSelectBox() {
    var req = await RequestSerializer.Deserialize<ItemOpenSelectBoxRequest>(Request);

    var res = ItemModel.Item_OpenSelectBox(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item/sell")]
public async Task<IActionResult> Item_Sell() {
    var req = await RequestSerializer.Deserialize<ItemSellRequest>(Request);

    var res = ItemModel.Item_Sell(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item/synthesize")]
public async Task<IActionResult> Item_Synthesize() {
    var req = await RequestSerializer.Deserialize<ItemSynthesizeRequest>(Request);

    var res = ItemModel.Item_Synthesize(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item/use_supply")]
public async Task<IActionResult> Item_UseSupply() {
    var req = await RequestSerializer.Deserialize<ItemUseSupplyRequest>(Request);

    var res = ItemModel.Item_UseSupply(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item/use_supply_gear_effect")]
public async Task<IActionResult> Item_UseSupplyGearEffect() {
    var req = await RequestSerializer.Deserialize<ItemUseSupplyGearEffectRequest>(Request);

    var res = ItemModel.Item_UseSupplyGearEffect(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
