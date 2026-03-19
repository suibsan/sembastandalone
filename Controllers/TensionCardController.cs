
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class TensionCardController : Controller {

private TensionCardModel model;

public TensionCardController(ISembaWrapper wrapper) {
    model = new TensionCardModel(wrapper);
}


[Route("/tension_card/disassemble")]
public async Task<IActionResult> TensionCard_Disassemble() {
    var req = await RequestSerializer.Deserialize<TensionCardDisassembleRequest>(Request);

    var res = model.TensionCard_Disassemble(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/tension_card/enhance")]
public async Task<IActionResult> TensionCard_Enhance() {
    var req = await RequestSerializer.Deserialize<TensionCardEnhanceRequest>(Request);

    var res = model.TensionCard_Enhance(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/tension_card/level_limit_enhance")]
public async Task<IActionResult> TensionCard_LevelLimitEnhance() {
    var req = await RequestSerializer.Deserialize<TensionCardLevelLimitEnhanceRequest>(Request);

    var res = model.TensionCard_LevelLimitEnhance(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/tension_card/limit_break_enhance")]
public async Task<IActionResult> TensionCard_LimitBreakEnhance() {
    var req = await RequestSerializer.Deserialize<TensionCardLimitBreakEnhanceRequest>(Request);

    var res = model.TensionCard_LimitBreakEnhance(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/tension_card/lock")]
public async Task<IActionResult> TensionCard_Lock() {
    var req = await RequestSerializer.Deserialize<TensionCardLockRequest>(Request);

    var res = model.TensionCard_Lock(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
