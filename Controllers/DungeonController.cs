
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class DungeonController : Controller {

[Route("/dungeon/acquire_area_item")]
public async Task<IActionResult> Dungeon_AcquireAreaItem() {
    var req = await RequestSerializer.Deserialize<DungeonAcquireAreaItemRequest>(Request);

    var res = DungeonModel.Dungeon_AcquireAreaItem(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/dungeon/battle_skip")]
public async Task<IActionResult> Dungeon_BattleSkip() {
    var req = await RequestSerializer.Deserialize<DungeonBattleSkipRequest>(Request);

    var res = DungeonModel.Dungeon_BattleSkip(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/dungeon/battle_start")]
public async Task<IActionResult> Dungeon_BattleStart() {
    var req = await RequestSerializer.Deserialize<DungeonBattleStartRequest>(Request);

    var res = DungeonModel.Dungeon_BattleStart(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/dungeon/entry")]
public async Task<IActionResult> Dungeon_Entry() {
    var req = await RequestSerializer.Deserialize<DungeonEntryRequest>(Request);

    var res = DungeonModel.Dungeon_Entry(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/dungeon/finish")]
public async Task<IActionResult> Dungeon_Finish() {
    var req = await RequestSerializer.Deserialize<DungeonFinishRequest>(Request);

    var res = DungeonModel.Dungeon_Finish(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/dungeon/resume")]
public async Task<IActionResult> Dungeon_Resume() {
    var req = await RequestSerializer.Deserialize<DungeonResumeRequest>(Request);

    var res = DungeonModel.Dungeon_Resume(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/dungeon/start")]
public async Task<IActionResult> Dungeon_Start() {
    var req = await RequestSerializer.Deserialize<DungeonStartRequest>(Request);

    var res = DungeonModel.Dungeon_Start(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
