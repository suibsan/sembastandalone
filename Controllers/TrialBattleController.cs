
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class TrialBattleController : Controller {

private TrialBattleModel model;

public TrialBattleController(ISembaWrapper wrapper) {
    model = new TrialBattleModel(wrapper);
}


[Route("/trial_battle/reward_receive")]
public async Task<IActionResult> TrialBattle_RewardReceive() {
    var req = await RequestSerializer.Deserialize<TrialBattleRewardReceiveRequest>(Request);

    var res = model.TrialBattle_RewardReceive(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/trial_battle/start")]
public async Task<IActionResult> TrialBattle_Start() {
    var req = await RequestSerializer.Deserialize<TrialBattleStartRequest>(Request);

    var res = model.TrialBattle_Start(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
