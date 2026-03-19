
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class FractalViseController : Controller {

private FractalViseModel model;

public FractalViseController(ISembaWrapper wrapper) {
    model = new FractalViseModel(wrapper);
}


[Route("/fractal_vise/acquire_area_item")]
public async Task<IActionResult> FractalVise_AcquireAreaItem() {
    var req = await RequestSerializer.Deserialize<FractalViseAcquireAreaItemRequest>(Request);

    var res = model.FractalVise_AcquireAreaItem(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/battle_start")]
public async Task<IActionResult> FractalVise_BattleStart() {
    var req = await RequestSerializer.Deserialize<FractalViseBattleStartRequest>(Request);

    var res = model.FractalVise_BattleStart(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/battle_start_boss_battle")]
public async Task<IActionResult> FractalVise_BattleStartBossBattle() {
    var req = await RequestSerializer.Deserialize<FractalViseBattleStartBossBattleRequest>(Request);

    var res = model.FractalVise_BattleStartBossBattle(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/boss_difficulty")]
public async Task<IActionResult> FractalVise_BossDifficulty() {
    var req = await RequestSerializer.Deserialize<FractalViseBossDifficultyRequest>(Request);

    var res = model.FractalVise_BossDifficulty(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/clear")]
public async Task<IActionResult> FractalVise_Clear() {
    var req = await RequestSerializer.Deserialize<FractalViseClearRequest>(Request);

    var res = model.FractalVise_Clear(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/next_area")]
public async Task<IActionResult> FractalVise_NextArea() {
    var req = await RequestSerializer.Deserialize<FractalViseNextAreaRequest>(Request);

    var res = model.FractalVise_NextArea(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/resume")]
public async Task<IActionResult> FractalVise_Resume() {
    var req = await RequestSerializer.Deserialize<FractalViseResumeRequest>(Request);

    var res = model.FractalVise_Resume(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/retire")]
public async Task<IActionResult> FractalVise_Retire() {
    var req = await RequestSerializer.Deserialize<FractalViseRetireRequest>(Request);

    var res = model.FractalVise_Retire(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/rewards_receive")]
public async Task<IActionResult> FractalVise_RewardsReceive() {
    var req = await RequestSerializer.Deserialize<FractalViseRewardsReceiveRequest>(Request);

    var res = model.FractalVise_RewardsReceive(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/rewards_top")]
public async Task<IActionResult> FractalVise_RewardsTop() {
    var req = await RequestSerializer.Deserialize<FractalViseRewardsTopRequest>(Request);

    var res = model.FractalVise_RewardsTop(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/fractal_vise/start")]
public async Task<IActionResult> FractalVise_Start() {
    var req = await RequestSerializer.Deserialize<FractalViseStartRequest>(Request);

    var res = model.FractalVise_Start(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
