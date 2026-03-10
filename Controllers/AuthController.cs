using Microsoft.AspNetCore.Mvc;
using ProtoBuf;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class AuthController : Controller {
    [Route("/auth/steam_user")]
    public async Task<FileContentResult> Auth_SteamUser() {
        var req = await RequestSerializer.Deserialize<AuthSteamUserRequest>(Request);

        var res = AuthModel.Auth_SteamUser(req);

        return RequestSerializer.Serialize(res);
    }
}