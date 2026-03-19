
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class StaminaController : Controller {

private StaminaModel model;

public StaminaController(ISembaWrapper wrapper) {
    model = new StaminaModel(wrapper);
}


[Route("/stamina/purchase")]
public async Task<IActionResult> Stamina_Purchase() {
    var req = await RequestSerializer.Deserialize<StaminaPurchaseRequest>(Request);

    var res = model.Stamina_Purchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/stamina/use_item")]
public async Task<IActionResult> Stamina_UseItem() {
    var req = await RequestSerializer.Deserialize<StaminaUseItemRequest>(Request);

    var res = model.Stamina_UseItem(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
