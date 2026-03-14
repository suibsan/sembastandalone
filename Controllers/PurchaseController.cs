
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class PurchaseController : Controller {

[Route("/purchase/history")]
public IActionResult Purchase_History() {
    // no request

    var res = PurchaseModel.Purchase_History();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/purchase/session_publish")]
public async Task Purchase_SessionPublish() {
    var req = await RequestSerializer.Deserialize<PurchaseSessionPublishRequest>(Request);

    PurchaseModel.Purchase_SessionPublish(req);

    // no response
}


[Route("/purchase/session_start")]
public async Task<IActionResult> Purchase_SessionStart() {
    var req = await RequestSerializer.Deserialize<PurchaseSessionStartRequest>(Request);

    var res = PurchaseModel.Purchase_SessionStart(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/purchase/verify")]
public async Task<IActionResult> Purchase_Verify() {
    var req = await RequestSerializer.Deserialize<PurchaseVerifyRequest>(Request);

    var res = PurchaseModel.Purchase_Verify(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
