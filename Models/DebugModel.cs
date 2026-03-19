
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class DebugModel {

public DebugChallengeClearResponse? Debug_ChallengeClear(DebugChallengeClearRequest req) {
    Console.WriteLine($"Debug_ChallengeClear: {req}");
    return DebugChallengeClearResponse.Parser.ParseJson(
        sembaWrapper.Call("/debug/challenge_clear", req.ToString())
    );
}


public void Debug_ClientError() {
    // no request
    sembaWrapper.Call("/debug/client_error", "");
}


public DebugJiraTokenResponse? Debug_JiraToken() {
    // no request
    return DebugJiraTokenResponse.Parser.ParseJson(
        sembaWrapper.Call("/debug/jira_token", "")
    );
}


public void Debug_MailSend(DebugMailSendRequest req) {
    Console.WriteLine($"Debug_MailSend: {req}");
    sembaWrapper.Call("/debug/mail_send", req.ToString());
}


public void Debug_ServerError() {
    // no request
    sembaWrapper.Call("/debug/server_error", "");
}


public ChangedResourcesResponse? Debug_ShopPurchase(DebugShopPurchaseRequest req) {
    Console.WriteLine($"Debug_ShopPurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/debug/shop_purchase", req.ToString())
    );
}


public void Debug_UserBulkResource(DebugUserBulkResourceRequest req) {
    Console.WriteLine($"Debug_UserBulkResource: {req}");
    sembaWrapper.Call("/debug/user_bulk_resource", req.ToString());
}


public void Debug_UserError() {
    // no request
    sembaWrapper.Call("/debug/user_error", "");
}


public void Debug_XbPvpSpecifyEnemy(DebugXbPvpSpecifyEnemyRequest req) {
    Console.WriteLine($"Debug_XbPvpSpecifyEnemy: {req}");
    sembaWrapper.Call("/debug/xb_pvp_specify_enemy", req.ToString());
}


private ISembaWrapper sembaWrapper;

public DebugModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
