
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class FollowController : Controller {

[Route("/follow/add")]
public async Task<IActionResult> Follow_Add() {
    var req = await RequestSerializer.Deserialize<FollowAddRequest>(Request);

    var res = FollowModel.Follow_Add(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/detail")]
public async Task<IActionResult> Follow_Detail() {
    var req = await RequestSerializer.Deserialize<FollowDetailRequest>(Request);

    var res = FollowModel.Follow_Detail(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/list")]
public IActionResult Follow_List() {
    // no request

    var res = FollowModel.Follow_List();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/remove")]
public async Task<IActionResult> Follow_Remove() {
    var req = await RequestSerializer.Deserialize<FollowRemoveRequest>(Request);

    var res = FollowModel.Follow_Remove(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/follow/search")]
public async Task<IActionResult> Follow_Search() {
    var req = await RequestSerializer.Deserialize<FollowSearchRequest>(Request);

    var res = FollowModel.Follow_Search(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
