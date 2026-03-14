
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class GearController : Controller {

[Route("/gear/compress")]
public async Task<IActionResult> Gear_Compress() {
    var req = await RequestSerializer.Deserialize<GearCompressRequest>(Request);

    var res = GearModel.Gear_Compress(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/gear/lock")]
public async Task<IActionResult> Gear_Lock() {
    var req = await RequestSerializer.Deserialize<GearLockRequest>(Request);

    var res = GearModel.Gear_Lock(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/gear/unlock")]
public async Task<IActionResult> Gear_Unlock() {
    var req = await RequestSerializer.Deserialize<GearUnlockRequest>(Request);

    var res = GearModel.Gear_Unlock(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
