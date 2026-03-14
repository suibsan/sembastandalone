
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class MailController : Controller {

[Route("/mail/delete")]
public async Task<IActionResult> Mail_Delete() {
    var req = await RequestSerializer.Deserialize<MailDeleteRequest>(Request);

    var res = MailModel.Mail_Delete(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/mail/list")]
public IActionResult Mail_List() {
    // no request

    var res = MailModel.Mail_List();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/mail/open")]
public async Task<IActionResult> Mail_Open() {
    var req = await RequestSerializer.Deserialize<MailOpenRequest>(Request);

    var res = MailModel.Mail_Open(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
