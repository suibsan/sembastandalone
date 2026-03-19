
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class LoginBonusController : Controller {

private LoginBonusModel model;

public LoginBonusController(ISembaWrapper wrapper) {
    model = new LoginBonusModel(wrapper);
}


[Route("/login_bonus/list")]
public IActionResult LoginBonus_List() {
    // no request

    var res = model.LoginBonus_List();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/login_bonus/receive")]
public async Task<IActionResult> LoginBonus_Receive() {
    var req = await RequestSerializer.Deserialize<LoginBonusReceiveRequest>(Request);

    var res = model.LoginBonus_Receive(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
