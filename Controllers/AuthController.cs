using Microsoft.AspNetCore.Mvc;
using ProtoBuf;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class AuthController : Controller {
    [Route("/auth/steam_user")]
    public async Task<FileContentResult> Auth_SteamUser() {
        using (var memoryStream = new MemoryStream()) {
            await Request.Body.CopyToAsync(memoryStream);
            var data = memoryStream.ToArray();
            var decData = Encryptor.DecryptData(data);

            var req = Serializer.Deserialize<AuthSteamUserRequest>(new ReadOnlySpan<byte>(decData));
            var res = AuthModel.Auth_SteamUser(req);

            using (var resMs = new MemoryStream()) {
                Serializer.Serialize(resMs, res);
                var resData = resMs.ToArray();
                return new FileContentResult(Encryptor.EncryptData(resData, 0), "application/octet-stream");
            }
        }
    }
}