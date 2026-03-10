namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class AuthModel {
    public static AuthSteamUserResponse? Auth_SteamUser(AuthSteamUserRequest req) {
        Console.WriteLine($"C#: SessionTicket={req.sessionTicket}");
        return SembaWrapper.Call<AuthSteamUserResponse, AuthSteamUserRequest>(
            "/auth/steam_user", req
        );
    }

    public static AuthSignInResponse? Auth_SignIn(AuthSignInRequest req) {
        Console.WriteLine($"C#: DeviceModel={req.deviceModel}");
        return SembaWrapper.Call<AuthSignInResponse, AuthSignInRequest>(
            "/auth/sign_in", req
        );
    }

    public static AuthNonceResponse? Auth_Nonce() {
        return SembaWrapper.Call<AuthNonceResponse>("/auth/nonce");
    }
}