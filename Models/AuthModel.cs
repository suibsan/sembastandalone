namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class AuthModel {
    public static AuthSteamUserResponse? Auth_SteamUser(AuthSteamUserRequest req) {
        Console.WriteLine($"C#: SessionTicket={req.SessionTicket}");
        return SembaWrapper.Call<AuthSteamUserResponse, AuthSteamUserRequest>(
            "/auth/steam_user", req
        );
    }
}