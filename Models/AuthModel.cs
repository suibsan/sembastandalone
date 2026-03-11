namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class AuthModel {
    public static AuthSteamUserResponse? Auth_SteamUser(AuthSteamUserRequest req) {
        Console.WriteLine($"C#: SessionTicket={req.SessionTicket}");
        return AuthSteamUserResponse.Parser.ParseJson(
            SembaWrapper.Call("/auth/steam_user", req.ToString())
        );
    }

    public static AuthSignInResponse? Auth_SignIn(AuthSignInRequest req) {
        Console.WriteLine($"C#: DeviceModel={req.DeviceModel}");
        return AuthSignInResponse.Parser.ParseJson(
            SembaWrapper.Call("/auth/sign_in", req.ToString())
        );
    }

    public static AuthNonceResponse? Auth_Nonce() {
        return AuthNonceResponse.Parser.ParseJson(SembaWrapper.Call("/auth/nonce", ""));
    }
}