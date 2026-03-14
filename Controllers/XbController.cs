
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class XbController : Controller {

[Route("/xb/add_command_unlock_item")]
public async Task<IActionResult> Xb_AddCommandUnlockItem() {
    var req = await RequestSerializer.Deserialize<XbAddCommandUnlockItemRequest>(Request);

    var res = XbModel.Xb_AddCommandUnlockItem(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/force_retire")]
public void Xb_ForceRetire() {
    // no request

    XbModel.Xb_ForceRetire();

    // no response
}


[Route("/xb/formation")]
public async Task<IActionResult> Xb_Formation() {
    var req = await RequestSerializer.Deserialize<XbFormationRequest>(Request);

    var res = XbModel.Xb_Formation(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/formation_update")]
public async Task<IActionResult> Xb_FormationUpdate() {
    var req = await RequestSerializer.Deserialize<XbFormationUpdateRequest>(Request);

    var res = XbModel.Xb_FormationUpdate(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/play")]
public async Task<IActionResult> Xb_Play() {
    var req = await RequestSerializer.Deserialize<XbPlayRequest>(Request);

    var res = XbModel.Xb_Play(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/retire")]
public IActionResult Xb_Retire() {
    // no request

    var res = XbModel.Xb_Retire();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/start")]
public async Task<IActionResult> Xb_Start() {
    var req = await RequestSerializer.Deserialize<XbStartRequest>(Request);

    var res = XbModel.Xb_Start(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/status")]
public async Task<IActionResult> Xb_Status() {
    var req = await RequestSerializer.Deserialize<XbStatusRequest>(Request);

    var res = XbModel.Xb_Status(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/update_skill_orb_status")]
public async Task<IActionResult> Xb_UpdateSkillOrbStatus() {
    var req = await RequestSerializer.Deserialize<XbUpdateSkillOrbStatusRequest>(Request);

    var res = XbModel.Xb_UpdateSkillOrbStatus(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb/update_tension")]
public async Task<IActionResult> Xb_UpdateTension() {
    var req = await RequestSerializer.Deserialize<XbUpdateTensionRequest>(Request);

    var res = XbModel.Xb_UpdateTension(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
