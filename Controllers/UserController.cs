using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class UserController : Controller {
    [Route("/user/log_in")]
    public IActionResult User_LogIn() {
        var res = UserModel.User_LogIn();

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}