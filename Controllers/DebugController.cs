
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class DebugController : Controller {

[Route("/debug/challenge_clear")]
public async Task<IActionResult> Debug_ChallengeClear() {
    var req = await RequestSerializer.Deserialize<DebugChallengeClearRequest>(Request);

    var res = DebugModel.Debug_ChallengeClear(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/debug/client_error")]
public void Debug_ClientError() {
    // no request

    DebugModel.Debug_ClientError();

    // no response
}


[Route("/debug/jira_token")]
public IActionResult Debug_JiraToken() {
    // no request

    var res = DebugModel.Debug_JiraToken();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/debug/mail_send")]
public async Task Debug_MailSend() {
    var req = await RequestSerializer.Deserialize<DebugMailSendRequest>(Request);

    DebugModel.Debug_MailSend(req);

    // no response
}


[Route("/debug/server_error")]
public void Debug_ServerError() {
    // no request

    DebugModel.Debug_ServerError();

    // no response
}


[Route("/debug/shop_purchase")]
public async Task<IActionResult> Debug_ShopPurchase() {
    var req = await RequestSerializer.Deserialize<DebugShopPurchaseRequest>(Request);

    var res = DebugModel.Debug_ShopPurchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/debug/user_bulk_resource")]
public async Task Debug_UserBulkResource() {
    var req = await RequestSerializer.Deserialize<DebugUserBulkResourceRequest>(Request);

    DebugModel.Debug_UserBulkResource(req);

    // no response
}


[Route("/debug/user_error")]
public void Debug_UserError() {
    // no request

    DebugModel.Debug_UserError();

    // no response
}


[Route("/debug/xb_pvp_specify_enemy")]
public async Task Debug_XbPvpSpecifyEnemy() {
    var req = await RequestSerializer.Deserialize<DebugXbPvpSpecifyEnemyRequest>(Request);

    DebugModel.Debug_XbPvpSpecifyEnemy(req);

    // no response
}

}
