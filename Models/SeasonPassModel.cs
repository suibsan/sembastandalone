
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class SeasonPassModel {

public static SeasonPassPurchasePaidPassResponse? SeasonPass_PurchasePaidPass(SeasonPassPurchasePaidPassRequest req) {
    Console.WriteLine($"SeasonPass_PurchasePaidPass: {req}");
    return SeasonPassPurchasePaidPassResponse.Parser.ParseJson(
        SembaWrapper.Call("/season_pass/purchase_paid_pass", req.ToString())
    );
}


public static SeasonPassReceiveResponse? SeasonPass_Receive(SeasonPassReceiveRequest req) {
    Console.WriteLine($"SeasonPass_Receive: {req}");
    return SeasonPassReceiveResponse.Parser.ParseJson(
        SembaWrapper.Call("/season_pass/receive", req.ToString())
    );
}


public static SeasonPassReceiveAllResponse? SeasonPass_ReceiveAll(SeasonPassReceiveAllRequest req) {
    Console.WriteLine($"SeasonPass_ReceiveAll: {req}");
    return SeasonPassReceiveAllResponse.Parser.ParseJson(
        SembaWrapper.Call("/season_pass/receive_all", req.ToString())
    );
}


public static ChangedResourcesResponse? SeasonPass_TierPurchase(SeasonPassTierPurchaseRequest req) {
    Console.WriteLine($"SeasonPass_TierPurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/season_pass/tier_purchase", req.ToString())
    );
}

}
