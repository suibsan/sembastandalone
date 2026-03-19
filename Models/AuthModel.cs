
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class AuthModel {

public AuthNonceResponse? Auth_Nonce() {
    // no request
    return AuthNonceResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/nonce", "")
    );
}


public AuthSignInResponse? Auth_SignIn(AuthSignInRequest req) {
    Console.WriteLine($"Auth_SignIn: {req}");
    return AuthSignInResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/sign_in", req.ToString())
    );
}


public AuthSignUpResponse? Auth_SignUp(AuthSignUpRequest req) {
    Console.WriteLine($"Auth_SignUp: {req}");
    return AuthSignUpResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/sign_up", req.ToString())
    );
}


public AuthSignUpAppleResponse? Auth_SignUpApple(AuthSignUpAppleRequest req) {
    Console.WriteLine($"Auth_SignUpApple: {req}");
    return AuthSignUpAppleResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/sign_up_apple", req.ToString())
    );
}


public AuthSignUpGoogleResponse? Auth_SignUpGoogle(AuthSignUpGoogleRequest req) {
    Console.WriteLine($"Auth_SignUpGoogle: {req}");
    return AuthSignUpGoogleResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/sign_up_google", req.ToString())
    );
}


public AuthSignUpPasscodeResponse? Auth_SignUpPasscode(AuthSignUpPasscodeRequest req) {
    Console.WriteLine($"Auth_SignUpPasscode: {req}");
    return AuthSignUpPasscodeResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/sign_up_passcode", req.ToString())
    );
}


public AuthSteamUserResponse? Auth_SteamUser(AuthSteamUserRequest req) {
    Console.WriteLine($"Auth_SteamUser: {req}");
    return AuthSteamUserResponse.Parser.ParseJson(
        sembaWrapper.Call("/auth/steam_user", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public AuthModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
