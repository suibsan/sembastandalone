
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class PurchaseModel {

public PurchaseHistoryResponse? Purchase_History() {
    // no request
    return PurchaseHistoryResponse.Parser.ParseJson(
        sembaWrapper.Call("/purchase/history", "")
    );
}


public void Purchase_SessionPublish(PurchaseSessionPublishRequest req) {
    Console.WriteLine($"Purchase_SessionPublish: {req}");
    sembaWrapper.Call("/purchase/session_publish", req.ToString());
}


public PurchaseSessionStartResponse? Purchase_SessionStart(PurchaseSessionStartRequest req) {
    Console.WriteLine($"Purchase_SessionStart: {req}");
    return PurchaseSessionStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/purchase/session_start", req.ToString())
    );
}


public ChangedResourcesResponse? Purchase_Verify(PurchaseVerifyRequest req) {
    Console.WriteLine($"Purchase_Verify: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/purchase/verify", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public PurchaseModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
