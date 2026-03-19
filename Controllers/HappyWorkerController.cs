
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class HappyWorkerController : Controller {

private HappyWorkerModel model;

public HappyWorkerController(ISembaWrapper wrapper) {
    model = new HappyWorkerModel(wrapper);
}


[Route("/happy_worker/cancel")]
public async Task<IActionResult> HappyWorker_Cancel() {
    var req = await RequestSerializer.Deserialize<HappyWorkerCancelRequest>(Request);

    var res = model.HappyWorker_Cancel(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/happy_worker/list")]
public async Task<IActionResult> HappyWorker_List() {
    var req = await RequestSerializer.Deserialize<HappyWorkerListRequest>(Request);

    var res = model.HappyWorker_List(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/happy_worker/start")]
public async Task<IActionResult> HappyWorker_Start() {
    var req = await RequestSerializer.Deserialize<HappyWorkerStartRequest>(Request);

    var res = model.HappyWorker_Start(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
