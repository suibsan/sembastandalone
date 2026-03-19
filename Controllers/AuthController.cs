
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class AuthController : Controller {

private AuthModel model;

public AuthController(ISembaWrapper wrapper) {
    model = new AuthModel(wrapper);
}


[Route("/auth/nonce")]
public IActionResult Auth_Nonce() {
    // no request

    var res = model.Auth_Nonce();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/auth/sign_in")]
public async Task<IActionResult> Auth_SignIn() {
    var req = await RequestSerializer.Deserialize<AuthSignInRequest>(Request);

    var res = model.Auth_SignIn(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/auth/sign_up")]
public async Task<IActionResult> Auth_SignUp() {
    var req = await RequestSerializer.Deserialize<AuthSignUpRequest>(Request);

    var res = model.Auth_SignUp(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/auth/sign_up_apple")]
public async Task<IActionResult> Auth_SignUpApple() {
    var req = await RequestSerializer.Deserialize<AuthSignUpAppleRequest>(Request);

    var res = model.Auth_SignUpApple(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/auth/sign_up_google")]
public async Task<IActionResult> Auth_SignUpGoogle() {
    var req = await RequestSerializer.Deserialize<AuthSignUpGoogleRequest>(Request);

    var res = model.Auth_SignUpGoogle(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/auth/sign_up_passcode")]
public async Task<IActionResult> Auth_SignUpPasscode() {
    var req = await RequestSerializer.Deserialize<AuthSignUpPasscodeRequest>(Request);

    var res = model.Auth_SignUpPasscode(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/auth/steam_user")]
public async Task<IActionResult> Auth_SteamUser() {
    var req = await RequestSerializer.Deserialize<AuthSteamUserRequest>(Request);

    var res = model.Auth_SteamUser(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
