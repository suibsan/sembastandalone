
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class LoginBonusModel {

public static ChangedResourcesResponse? LoginBonus_List() {
    // no request
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/login_bonus/list", "")
    );
}


public static LoginBonusReceiveResponse? LoginBonus_Receive(LoginBonusReceiveRequest req) {
    Console.WriteLine($"LoginBonus_Receive: {req}");
    return LoginBonusReceiveResponse.Parser.ParseJson(
        SembaWrapper.Call("/login_bonus/receive", req.ToString())
    );
}

}
