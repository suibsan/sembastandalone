namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;

public class AuthModel {
    public static AuthSteamUserResponse Auth_SteamUser(AuthSteamUserRequest req) {
        Console.WriteLine($"SessionTicket={req.SessionTicket}");
        return new AuthSteamUserResponse{ UserId=696969696969 };
    }
}