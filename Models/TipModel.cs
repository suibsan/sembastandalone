
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TipModel {

public static TipReleaseResponse? Tip_Release(TipReleaseRequest req) {
    Console.WriteLine($"Tip_Release: {req}");
    return TipReleaseResponse.Parser.ParseJson(
        SembaWrapper.Call("/tip/release", req.ToString())
    );
}


public static ChangedResourcesResponse? Tip_ReleaseByBattle(TipReleaseByBattleRequest req) {
    Console.WriteLine($"Tip_ReleaseByBattle: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/tip/release_by_battle", req.ToString())
    );
}

}
