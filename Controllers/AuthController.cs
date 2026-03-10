using Microsoft.AspNetCore.Mvc;
using ProtoBuf;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class AuthController : Controller {
    [Route("/auth/steam_user")]
    public async Task<IActionResult> Auth_SteamUser() {
        var req = await RequestSerializer.Deserialize<AuthSteamUserRequest>(Request);

        var res = AuthModel.Auth_SteamUser(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/auth/sign_in")]
    public async Task<IActionResult> Auth_SignIn() {
        var req = await RequestSerializer.Deserialize<AuthSignInRequest>(Request);

        var res = AuthModel.Auth_SignIn(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/auth/nonce")]
    public IActionResult Auth_Nonce() {
        var res = AuthModel.Auth_Nonce();

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}