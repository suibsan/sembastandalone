using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class TensionCardController : Controller {
    [Route("/tension_card/limit_break_enhance")]
    public async Task<IActionResult> TensionCard_LimitBreakEnhance() {
        var req = await RequestSerializer.Deserialize<TensionCardLimitBreakEnhanceRequest>(Request);

        var res = TensionCardModel.TensionCard_LimitBreakEnhance(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/tension_card/lock")]
    public async Task<IActionResult> TensionCard_Lock() {
        var req = await RequestSerializer.Deserialize<TensionCardLockRequest>(Request);

        var res = TensionCardModel.TensionCard_Lock(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}