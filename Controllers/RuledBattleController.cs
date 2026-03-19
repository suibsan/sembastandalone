
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class RuledBattleController : Controller {

private RuledBattleModel model;

public RuledBattleController(ISembaWrapper wrapper) {
    model = new RuledBattleModel(wrapper);
}


[Route("/ruled_battle/start")]
public async Task<IActionResult> RuledBattle_Start() {
    var req = await RequestSerializer.Deserialize<RuledBattleStartRequest>(Request);

    var res = model.RuledBattle_Start(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
