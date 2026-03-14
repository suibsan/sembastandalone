
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class GachaModel {

public static GachaExecuteResponse? Gacha_Execute(GachaExecuteRequest req) {
    Console.WriteLine($"Gacha_Execute: {req}");
    return GachaExecuteResponse.Parser.ParseJson(
        SembaWrapper.Call("/gacha/execute", req.ToString())
    );
}


public static GachaListResponse? Gacha_List() {
    // no request
    return GachaListResponse.Parser.ParseJson(
        SembaWrapper.Call("/gacha/list", "")
    );
}


public static GachaSelectResponse? Gacha_Select(GachaSelectRequest req) {
    Console.WriteLine($"Gacha_Select: {req}");
    return GachaSelectResponse.Parser.ParseJson(
        SembaWrapper.Call("/gacha/select", req.ToString())
    );
}

}
