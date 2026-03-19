
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class LoginBonusModel {

public ChangedResourcesResponse? LoginBonus_List() {
    // no request
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/login_bonus/list", "")
    );
}


public LoginBonusReceiveResponse? LoginBonus_Receive(LoginBonusReceiveRequest req) {
    Console.WriteLine($"LoginBonus_Receive: {req}");
    return LoginBonusReceiveResponse.Parser.ParseJson(
        sembaWrapper.Call("/login_bonus/receive", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public LoginBonusModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
