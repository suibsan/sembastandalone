
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class FollowController : Controller {

private FollowModel model;

public FollowController(ISembaWrapper wrapper) {
    model = new FollowModel(wrapper);
}


[Route("/follow/add")]
public async Task<IActionResult> Follow_Add() {
    var req = await RequestSerializer.Deserialize<FollowAddRequest>(Request);

    var res = model.Follow_Add(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/detail")]
public async Task<IActionResult> Follow_Detail() {
    var req = await RequestSerializer.Deserialize<FollowDetailRequest>(Request);

    var res = model.Follow_Detail(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/list")]
public IActionResult Follow_List() {
    // no request

    var res = model.Follow_List();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/remove")]
public async Task<IActionResult> Follow_Remove() {
    var req = await RequestSerializer.Deserialize<FollowRemoveRequest>(Request);

    var res = model.Follow_Remove(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/search")]
public async Task<IActionResult> Follow_Search() {
    var req = await RequestSerializer.Deserialize<FollowSearchRequest>(Request);

    var res = model.Follow_Search(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
