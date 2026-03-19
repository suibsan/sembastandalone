
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class WebSessionController : Controller {

private WebSessionModel model;

public WebSessionController(ISembaWrapper wrapper) {
    model = new WebSessionModel(wrapper);
}


[Route("/web_session/token")]
public IActionResult WebSession_Token() {
    // no request

    var res = model.WebSession_Token();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
