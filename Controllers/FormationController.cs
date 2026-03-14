
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class FormationController : Controller {

[Route("/formation/switch")]
public async Task<IActionResult> Formation_Switch() {
    var req = await RequestSerializer.Deserialize<FormationSwitchRequest>(Request);

    var res = FormationModel.Formation_Switch(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/formation/update")]
public async Task<IActionResult> Formation_Update() {
    var req = await RequestSerializer.Deserialize<FormationUpdateRequest>(Request);

    var res = FormationModel.Formation_Update(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
