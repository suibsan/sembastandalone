
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class UserController : Controller {

private UserModel model;

public UserController(ISembaWrapper wrapper) {
    model = new UserModel(wrapper);
}


[Route("/user/cross_date")]
public IActionResult User_CrossDate() {
    // no request

    var res = model.User_CrossDate();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/delete")]
public IActionResult User_Delete() {
    // no request

    var res = model.User_Delete();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/link_apple")]
public async Task<IActionResult> User_LinkApple() {
    var req = await RequestSerializer.Deserialize<UserLinkAppleRequest>(Request);

    var res = model.User_LinkApple(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/link_google")]
public async Task<IActionResult> User_LinkGoogle() {
    var req = await RequestSerializer.Deserialize<UserLinkGoogleRequest>(Request);

    var res = model.User_LinkGoogle(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/links_list")]
public IActionResult User_LinksList() {
    // no request

    var res = model.User_LinksList();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/log_in")]
public IActionResult User_LogIn() {
    // no request

    var jsonRes = UserModel.requiresAssetsUpdates(Request);

    if (jsonRes != null) {
        var result = Json(jsonRes);
        result.StatusCode = 409;
        return result;
    }

    var res = model.User_LogIn();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/notification")]
public IActionResult User_Notification() {
    // no request

    var res = model.User_Notification();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/unlink_apple")]
public void User_UnlinkApple() {
    // no request

    model.User_UnlinkApple();

    // no response
}


[Route("/user/unlink_google")]
public void User_UnlinkGoogle() {
    // no request

    model.User_UnlinkGoogle();

    // no response
}


[Route("/user/unlink_steam")]
public void User_UnlinkSteam() {
    // no request

    model.User_UnlinkSteam();

    // no response
}


[Route("/user/update_birthdate")]
public async Task<IActionResult> User_UpdateBirthdate() {
    var req = await RequestSerializer.Deserialize<UserUpdateBirthdateRequest>(Request);

    var res = model.User_UpdateBirthdate(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/user/update_language")]
public async Task User_UpdateLanguage() {
    var req = await RequestSerializer.Deserialize<UserUpdateLanguageRequest>(Request);

    model.User_UpdateLanguage(req);

    // no response
}

}
