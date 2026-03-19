
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class XbPvpController : Controller {

private XbPvpModel model;

public XbPvpController(ISembaWrapper wrapper) {
    model = new XbPvpModel(wrapper);
}


[Route("/xb_pvp/casual_matching")]
public async Task<IActionResult> XbPvp_CasualMatching() {
    var req = await RequestSerializer.Deserialize<XbPvpCasualMatchingRequest>(Request);

    var res = model.XbPvp_CasualMatching(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb_pvp/entry")]
public IActionResult XbPvp_Entry() {
    // no request

    var res = model.XbPvp_Entry();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb_pvp/formation")]
public IActionResult XbPvp_Formation() {
    // no request

    var res = model.XbPvp_Formation();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb_pvp/formation_update")]
public async Task<IActionResult> XbPvp_FormationUpdate() {
    var req = await RequestSerializer.Deserialize<XbPvpFormationUpdateRequest>(Request);

    var res = model.XbPvp_FormationUpdate(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb_pvp/quick_matching")]
public IActionResult XbPvp_QuickMatching() {
    // no request

    var res = model.XbPvp_QuickMatching();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb_pvp/rank_match_history_list")]
public async Task<IActionResult> XbPvp_RankMatchHistoryList() {
    var req = await RequestSerializer.Deserialize<XbPvpRankMatchHistoryListRequest>(Request);

    var res = model.XbPvp_RankMatchHistoryList(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/xb_pvp/rank_matching")]
public IActionResult XbPvp_RankMatching() {
    // no request

    var res = model.XbPvp_RankMatching();

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
