using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class CharacterController : Controller {
    [Route("/character/costume_update")]
    public async Task<IActionResult> Character_CostumeUpdate() {
        var req = await RequestSerializer.Deserialize<CharacterCostumeUpdateRequest>(Request);

        var res = CharacterModel.Character_CostumeUpdate(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/character/limit_break")]
    public async Task<IActionResult> Character_LimitBreak() {
        var req = await RequestSerializer.Deserialize<CharacterLimitBreakRequest>(Request);

        var res = CharacterModel.Character_LimitBreak(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}