
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class EventController : Controller {

[Route("/event/finish_node")]
public async Task<IActionResult> Event_FinishNode() {
    var req = await RequestSerializer.Deserialize<EventFinishNodeRequest>(Request);

    var res = EventModel.Event_FinishNode(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/event/list_node")]
public IActionResult Event_ListNode() {
    // no request

    var res = EventModel.Event_ListNode();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
