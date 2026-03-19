
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class BattleController : Controller {

private BattleModel model;

public BattleController(ISembaWrapper wrapper) {
    model = new BattleModel(wrapper);
}


[Route("/battle/finish")]
public async Task<IActionResult> Battle_Finish() {
    var req = await RequestSerializer.Deserialize<BattleFinishRequest>(Request);

    var res = model.Battle_Finish(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/battle/restart")]
public async Task<IActionResult> Battle_Restart() {
    var req = await RequestSerializer.Deserialize<BattleRestartRequest>(Request);

    var res = model.Battle_Restart(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/battle/skip")]
public async Task<IActionResult> Battle_Skip() {
    var req = await RequestSerializer.Deserialize<BattleSkipRequest>(Request);

    var res = model.Battle_Skip(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/battle/start")]
public async Task<IActionResult> Battle_Start() {
    var req = await RequestSerializer.Deserialize<BattleStartRequest>(Request);

    var res = model.Battle_Start(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
