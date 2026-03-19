
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class SeasonPassController : Controller {

private SeasonPassModel model;

public SeasonPassController(ISembaWrapper wrapper) {
    model = new SeasonPassModel(wrapper);
}


[Route("/season_pass/purchase_paid_pass")]
public async Task<IActionResult> SeasonPass_PurchasePaidPass() {
    var req = await RequestSerializer.Deserialize<SeasonPassPurchasePaidPassRequest>(Request);

    var res = model.SeasonPass_PurchasePaidPass(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/season_pass/receive")]
public async Task<IActionResult> SeasonPass_Receive() {
    var req = await RequestSerializer.Deserialize<SeasonPassReceiveRequest>(Request);

    var res = model.SeasonPass_Receive(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/season_pass/receive_all")]
public async Task<IActionResult> SeasonPass_ReceiveAll() {
    var req = await RequestSerializer.Deserialize<SeasonPassReceiveAllRequest>(Request);

    var res = model.SeasonPass_ReceiveAll(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/season_pass/tier_purchase")]
public async Task<IActionResult> SeasonPass_TierPurchase() {
    var req = await RequestSerializer.Deserialize<SeasonPassTierPurchaseRequest>(Request);

    var res = model.SeasonPass_TierPurchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
