
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class GachaModel {

public GachaExecuteResponse? Gacha_Execute(GachaExecuteRequest req) {
    Console.WriteLine($"Gacha_Execute: {req}");
    return GachaExecuteResponse.Parser.ParseJson(
        sembaWrapper.Call("/gacha/execute", req.ToString())
    );
}


public GachaListResponse? Gacha_List() {
    // no request
    return GachaListResponse.Parser.ParseJson(
        sembaWrapper.Call("/gacha/list", "")
    );
}


public GachaSelectResponse? Gacha_Select(GachaSelectRequest req) {
    Console.WriteLine($"Gacha_Select: {req}");
    return GachaSelectResponse.Parser.ParseJson(
        sembaWrapper.Call("/gacha/select", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public GachaModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
