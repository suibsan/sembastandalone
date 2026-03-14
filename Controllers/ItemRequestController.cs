
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class ItemRequestController : Controller {

[Route("/item_request/cancel")]
public void ItemRequest_Cancel() {
    // no request

    ItemRequestModel.ItemRequest_Cancel();

    // no response
}


[Route("/item_request/collect")]
public IActionResult ItemRequest_Collect() {
    // no request

    var res = ItemRequestModel.ItemRequest_Collect();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item_request/fulfill")]
public async Task<IActionResult> ItemRequest_Fulfill() {
    var req = await RequestSerializer.Deserialize<ItemRequestFulfillRequest>(Request);

    var res = ItemRequestModel.ItemRequest_Fulfill(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item_request/get")]
public IActionResult ItemRequest_Get() {
    // no request

    var res = ItemRequestModel.ItemRequest_Get();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item_request/list")]
public IActionResult ItemRequest_List() {
    // no request

    var res = ItemRequestModel.ItemRequest_List();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/item_request/publish")]
public async Task<IActionResult> ItemRequest_Publish() {
    var req = await RequestSerializer.Deserialize<ItemRequestPublishRequest>(Request);

    var res = ItemRequestModel.ItemRequest_Publish(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
