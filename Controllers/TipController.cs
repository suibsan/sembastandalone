
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class TipController : Controller {

[Route("/tip/release")]
public async Task<IActionResult> Tip_Release() {
    var req = await RequestSerializer.Deserialize<TipReleaseRequest>(Request);

    var res = TipModel.Tip_Release(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/tip/release_by_battle")]
public async Task<IActionResult> Tip_ReleaseByBattle() {
    var req = await RequestSerializer.Deserialize<TipReleaseByBattleRequest>(Request);

    var res = TipModel.Tip_ReleaseByBattle(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
