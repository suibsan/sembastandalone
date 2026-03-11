using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class BattleController : Controller {
    [Route("/battle/finish")]
    public async Task<IActionResult> Battle_Finish() {
        var req = await RequestSerializer.Deserialize<BattleFinishRequest>(Request);

        var res = BattleModel.Battle_Finish(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/battle/start")]
    public async Task<IActionResult> Battle_Start() {
        var req = await RequestSerializer.Deserialize<BattleStartRequest>(Request);

        var res = BattleModel.Battle_Start(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}