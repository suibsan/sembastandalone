
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class TutorialController : Controller {

private TutorialModel model;

public TutorialController(ISembaWrapper wrapper) {
    model = new TutorialModel(wrapper);
}


[Route("/tutorial/skip")]
public IActionResult Tutorial_Skip() {
    // no request

    var res = model.Tutorial_Skip();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
