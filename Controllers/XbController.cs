using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class XbController : Controller {
    [Route("/xb/formation")]
    public async Task<IActionResult> Xb_Formation() {
        var req = await RequestSerializer.Deserialize<XbFormationRequest>(Request);

        var res = XbModel.Xb_Formation(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/xb/play")]
    public async Task<IActionResult> Xb_Play() {
        var req = await RequestSerializer.Deserialize<XbPlayRequest>(Request);

        var res = XbModel.Xb_Play(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/xb/start")]
    public async Task<IActionResult> Xb_Start() {
        var req = await RequestSerializer.Deserialize<XbStartRequest>(Request);

        var res = XbModel.Xb_Start(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/xb/update_tension")]
    public async Task<IActionResult> Xb_UpdateTension() {
        var req = await RequestSerializer.Deserialize<XbUpdateTensionRequest>(Request);

        var res = XbModel.Xb_UpdateTension(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}