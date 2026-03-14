
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class DebugModel {

public static DebugChallengeClearResponse? Debug_ChallengeClear(DebugChallengeClearRequest req) {
    Console.WriteLine($"Debug_ChallengeClear: {req}");
    return DebugChallengeClearResponse.Parser.ParseJson(
        SembaWrapper.Call("/debug/challenge_clear", req.ToString())
    );
}


public static void Debug_ClientError() {
    // no request
    SembaWrapper.Call("/debug/client_error", "");
}


public static DebugJiraTokenResponse? Debug_JiraToken() {
    // no request
    return DebugJiraTokenResponse.Parser.ParseJson(
        SembaWrapper.Call("/debug/jira_token", "")
    );
}


public static void Debug_MailSend(DebugMailSendRequest req) {
    Console.WriteLine($"Debug_MailSend: {req}");
    SembaWrapper.Call("/debug/mail_send", req.ToString());
}


public static void Debug_ServerError() {
    // no request
    SembaWrapper.Call("/debug/server_error", "");
}


public static ChangedResourcesResponse? Debug_ShopPurchase(DebugShopPurchaseRequest req) {
    Console.WriteLine($"Debug_ShopPurchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/debug/shop_purchase", req.ToString())
    );
}


public static void Debug_UserBulkResource(DebugUserBulkResourceRequest req) {
    Console.WriteLine($"Debug_UserBulkResource: {req}");
    SembaWrapper.Call("/debug/user_bulk_resource", req.ToString());
}


public static void Debug_UserError() {
    // no request
    SembaWrapper.Call("/debug/user_error", "");
}


public static void Debug_XbPvpSpecifyEnemy(DebugXbPvpSpecifyEnemyRequest req) {
    Console.WriteLine($"Debug_XbPvpSpecifyEnemy: {req}");
    SembaWrapper.Call("/debug/xb_pvp_specify_enemy", req.ToString());
}

}
