
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class AdventureController : Controller {

[Route("/adventure/access_warp_point")]
public async Task<IActionResult> Adventure_AccessWarpPoint() {
    var req = await RequestSerializer.Deserialize<AdventureAccessWarpPointRequest>(Request);

    var res = AdventureModel.Adventure_AccessWarpPoint(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/acquire_area_item")]
public async Task<IActionResult> Adventure_AcquireAreaItem() {
    var req = await RequestSerializer.Deserialize<AdventureAcquireAreaItemRequest>(Request);

    var res = AdventureModel.Adventure_AcquireAreaItem(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/area_object")]
public async Task<IActionResult> Adventure_AreaObject() {
    var req = await RequestSerializer.Deserialize<AdventureAreaObjectRequest>(Request);

    var res = AdventureModel.Adventure_AreaObject(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/find_graffiti")]
public async Task<IActionResult> Adventure_FindGraffiti() {
    var req = await RequestSerializer.Deserialize<AdventureFindGraffitiRequest>(Request);

    var res = AdventureModel.Adventure_FindGraffiti(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/hospital")]
public async Task<IActionResult> Adventure_Hospital() {
    var req = await RequestSerializer.Deserialize<AdventureHospitalRequest>(Request);

    var res = AdventureModel.Adventure_Hospital(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/move_to_area")]
public async Task<IActionResult> Adventure_MoveToArea() {
    var req = await RequestSerializer.Deserialize<AdventureMoveToAreaRequest>(Request);

    var res = AdventureModel.Adventure_MoveToArea(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/read_sequence")]
public async Task<IActionResult> Adventure_ReadSequence() {
    var req = await RequestSerializer.Deserialize<AdventureReadSequenceRequest>(Request);

    var res = AdventureModel.Adventure_ReadSequence(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/release_event_lift")]
public async Task<IActionResult> Adventure_ReleaseEventLift() {
    var req = await RequestSerializer.Deserialize<AdventureReleaseEventLiftRequest>(Request);

    var res = AdventureModel.Adventure_ReleaseEventLift(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/track_target")]
public async Task<IActionResult> Adventure_TrackTarget() {
    var req = await RequestSerializer.Deserialize<AdventureTrackTargetRequest>(Request);

    var res = AdventureModel.Adventure_TrackTarget(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/update_character_status")]
public async Task<IActionResult> Adventure_UpdateCharacterStatus() {
    var req = await RequestSerializer.Deserialize<AdventureUpdateCharacterStatusRequest>(Request);

    var res = AdventureModel.Adventure_UpdateCharacterStatus(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/adventure/warp_area_locator")]
public async Task<IActionResult> Adventure_WarpAreaLocator() {
    var req = await RequestSerializer.Deserialize<AdventureWarpAreaLocatorRequest>(Request);

    var res = AdventureModel.Adventure_WarpAreaLocator(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
