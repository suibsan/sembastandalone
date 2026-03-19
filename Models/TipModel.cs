
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TipModel {

public TipReleaseResponse? Tip_Release(TipReleaseRequest req) {
    Console.WriteLine($"Tip_Release: {req}");
    return TipReleaseResponse.Parser.ParseJson(
        sembaWrapper.Call("/tip/release", req.ToString())
    );
}


public ChangedResourcesResponse? Tip_ReleaseByBattle(TipReleaseByBattleRequest req) {
    Console.WriteLine($"Tip_ReleaseByBattle: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/tip/release_by_battle", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public TipModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
