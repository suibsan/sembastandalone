using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class GachaController : Controller {
    [Route("/gacha/execute")]
    public async Task<IActionResult> Gacha_Execute() {
        var req = await RequestSerializer.Deserialize<GachaExecuteRequest>(Request);

        var res = GachaModel.Gacha_Execute(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/gacha/list")]
    public IActionResult Gacha_List() {
        var res = GachaModel.Gacha_List();

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}