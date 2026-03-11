using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class UserController : Controller {
    [Route("/user/cross_date")]
    public IActionResult User_CrossDate() {
        var res = UserModel.User_CrossDate();

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/user/log_in")]
    public IActionResult User_LogIn() {
        var res = UserModel.User_LogIn();

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/user/notification")]
    public IActionResult User_Notification() {
        var res = UserModel.User_Notification();

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}