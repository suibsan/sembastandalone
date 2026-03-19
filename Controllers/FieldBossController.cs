
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class FieldBossController : Controller {

private FieldBossModel model;

public FieldBossController(ISembaWrapper wrapper) {
    model = new FieldBossModel(wrapper);
}


[Route("/field_boss/entry")]
public async Task<IActionResult> FieldBoss_Entry() {
    var req = await RequestSerializer.Deserialize<FieldBossEntryRequest>(Request);

    var res = model.FieldBoss_Entry(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
