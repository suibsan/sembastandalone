
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class ProfileController : Controller {

[Route("/profile/update_badges")]
public async Task<IActionResult> Profile_UpdateBadges() {
    var req = await RequestSerializer.Deserialize<ProfileUpdateBadgesRequest>(Request);

    var res = ProfileModel.Profile_UpdateBadges(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/profile/update_banner")]
public async Task<IActionResult> Profile_UpdateBanner() {
    var req = await RequestSerializer.Deserialize<ProfileUpdateBannerRequest>(Request);

    var res = ProfileModel.Profile_UpdateBanner(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/profile/update_character_likability_scale")]
public async Task<IActionResult> Profile_UpdateCharacterLikabilityScale() {
    var req = await RequestSerializer.Deserialize<ProfileUpdateCharacterLikabilityScaleRequest>(Request);

    var res = ProfileModel.Profile_UpdateCharacterLikabilityScale(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/profile/update_name")]
public async Task<IActionResult> Profile_UpdateName() {
    var req = await RequestSerializer.Deserialize<ProfileUpdateNameRequest>(Request);

    var res = ProfileModel.Profile_UpdateName(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
