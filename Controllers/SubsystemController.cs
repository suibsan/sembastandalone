
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class SubsystemController : Controller {

private SubsystemModel model;

public SubsystemController(ISembaWrapper wrapper) {
    model = new SubsystemModel(wrapper);
}


[Route("/subsystem/status")]
public IActionResult Subsystem_Status() {
    // no request

    var res = model.Subsystem_Status();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
