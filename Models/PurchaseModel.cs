
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class PurchaseModel {

public static PurchaseHistoryResponse? Purchase_History() {
    // no request
    return PurchaseHistoryResponse.Parser.ParseJson(
        SembaWrapper.Call("/purchase/history", "")
    );
}


public static void Purchase_SessionPublish(PurchaseSessionPublishRequest req) {
    Console.WriteLine($"Purchase_SessionPublish: {req}");
    SembaWrapper.Call("/purchase/session_publish", req.ToString());
}


public static PurchaseSessionStartResponse? Purchase_SessionStart(PurchaseSessionStartRequest req) {
    Console.WriteLine($"Purchase_SessionStart: {req}");
    return PurchaseSessionStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/purchase/session_start", req.ToString())
    );
}


public static ChangedResourcesResponse? Purchase_Verify(PurchaseVerifyRequest req) {
    Console.WriteLine($"Purchase_Verify: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/purchase/verify", req.ToString())
    );
}

}
