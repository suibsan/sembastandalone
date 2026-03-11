namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class GachaModel {
    public static GachaExecuteResponse? Gacha_Execute(GachaExecuteRequest req) {
        Console.WriteLine($"Gacha_Execute: ${req}");
        return GachaExecuteResponse.Parser.ParseJson(
            SembaWrapper.Call("/gacha/excute", req.ToString())
        );
    }

    public static GachaListResponse? Gacha_List() {
        return GachaListResponse.Parser.ParseJson(
            SembaWrapper.Call("/gacha/list", "")
        );
    }
}