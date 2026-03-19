
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class MissionController : Controller {

private MissionModel model;

public MissionController(ISembaWrapper wrapper) {
    model = new MissionModel(wrapper);
}


[Route("/mission/count_reward_receive")]
public async Task<IActionResult> Mission_CountRewardReceive() {
    var req = await RequestSerializer.Deserialize<MissionCountRewardReceiveRequest>(Request);

    var res = model.Mission_CountRewardReceive(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/mission/receive")]
public async Task<IActionResult> Mission_Receive() {
    var req = await RequestSerializer.Deserialize<MissionReceiveRequest>(Request);

    var res = model.Mission_Receive(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
