
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class GachaController : Controller {

private GachaModel model;

public GachaController(ISembaWrapper wrapper) {
    model = new GachaModel(wrapper);
}


[Route("/gacha/execute")]
public async Task<IActionResult> Gacha_Execute() {
    var req = await RequestSerializer.Deserialize<GachaExecuteRequest>(Request);

    var res = model.Gacha_Execute(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/gacha/list")]
public IActionResult Gacha_List() {
    // no request

    var res = model.Gacha_List();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/gacha/select")]
public async Task<IActionResult> Gacha_Select() {
    var req = await RequestSerializer.Deserialize<GachaSelectRequest>(Request);

    var res = model.Gacha_Select(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
