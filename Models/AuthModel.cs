
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class AuthModel {

public static AuthNonceResponse? Auth_Nonce() {
    // no request
    return AuthNonceResponse.Parser.ParseJson(
        SembaWrapper.Call("/auth/nonce", "")
    );
}


public static AuthSignInResponse? Auth_SignIn(AuthSignInRequest req) {
    Console.WriteLine($"Auth_SignIn: {req}");
    return AuthSignInResponse.Parser.ParseJson(
        SembaWrapper.Call("/auth/sign_in", req.ToString())
    );
}


public static AuthSignUpResponse? Auth_SignUp(AuthSignUpRequest req) {
    Console.WriteLine($"Auth_SignUp: {req}");
    return AuthSignUpResponse.Parser.ParseJson(
        SembaWrapper.Call("/auth/sign_up", req.ToString())
    );
}


public static AuthSignUpAppleResponse? Auth_SignUpApple(AuthSignUpAppleRequest req) {
    Console.WriteLine($"Auth_SignUpApple: {req}");
    return AuthSignUpAppleResponse.Parser.ParseJson(
        SembaWrapper.Call("/auth/sign_up_apple", req.ToString())
    );
}


public static AuthSignUpGoogleResponse? Auth_SignUpGoogle(AuthSignUpGoogleRequest req) {
    Console.WriteLine($"Auth_SignUpGoogle: {req}");
    return AuthSignUpGoogleResponse.Parser.ParseJson(
        SembaWrapper.Call("/auth/sign_up_google", req.ToString())
    );
}


public static AuthSignUpPasscodeResponse? Auth_SignUpPasscode(AuthSignUpPasscodeRequest req) {
    Console.WriteLine($"Auth_SignUpPasscode: {req}");
    return AuthSignUpPasscodeResponse.Parser.ParseJson(
        SembaWrapper.Call("/auth/sign_up_passcode", req.ToString())
    );
}


public static AuthSteamUserResponse? Auth_SteamUser(AuthSteamUserRequest req) {
    Console.WriteLine($"Auth_SteamUser: {req}");
    return AuthSteamUserResponse.Parser.ParseJson(
        SembaWrapper.Call("/auth/steam_user", req.ToString())
    );
}

}
