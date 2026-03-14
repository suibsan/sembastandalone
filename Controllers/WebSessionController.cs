
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class WebSessionController : Controller {

[Route("/web_session/token")]
public IActionResult WebSession_Token() {
    // no request

    var res = WebSessionModel.WebSession_Token();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
