
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class SeasonPassModel {

public SeasonPassPurchasePaidPassResponse? SeasonPass_PurchasePaidPass(SeasonPassPurchasePaidPassRequest req) {
    Console.WriteLine($"SeasonPass_PurchasePaidPass: {req}");
    return SeasonPassPurchasePaidPassResponse.Parser.ParseJson(
        sembaWrapper.Call("/season_pass/purchase_paid_pass", req.ToString())
    );
}


public SeasonPassReceiveResponse? SeasonPass_Receive(SeasonPassReceiveRequest req) {
    Console.WriteLine($"SeasonPass_Receive: {req}");
    return SeasonPassReceiveResponse.Parser.ParseJson(
        sembaWrapper.Call("/season_pass/receive", req.ToString())
    );
}


public SeasonPassReceiveAllResponse? SeasonPass_ReceiveAll(SeasonPassReceiveAllRequest req) {
    Console.WriteLine($"SeasonPass_ReceiveAll: {req}");
    return SeasonPassReceiveAllResponse.Parser.ParseJson(
        sembaWrapper.Call("/season_pass/receive_all", req.ToString())
    );
}


public ChangedResourcesResponse? SeasonPass_TierPurchase(SeasonPassTierPurchaseRequest req) {
    Console.WriteLine($"SeasonPass_TierPurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/season_pass/tier_purchase", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public SeasonPassModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
