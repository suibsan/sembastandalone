
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class CharacterController : Controller {

private CharacterModel model;

public CharacterController(ISembaWrapper wrapper) {
    model = new CharacterModel(wrapper);
}


[Route("/character/costume_update")]
public async Task<IActionResult> Character_CostumeUpdate() {
    var req = await RequestSerializer.Deserialize<CharacterCostumeUpdateRequest>(Request);

    var res = model.Character_CostumeUpdate(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/character/enhance")]
public async Task<IActionResult> Character_Enhance() {
    var req = await RequestSerializer.Deserialize<CharacterEnhanceRequest>(Request);

    var res = model.Character_Enhance(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/character/equip")]
public async Task<IActionResult> Character_Equip() {
    var req = await RequestSerializer.Deserialize<CharacterEquipRequest>(Request);

    var res = model.Character_Equip(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/character/item_present")]
public async Task<IActionResult> Character_ItemPresent() {
    var req = await RequestSerializer.Deserialize<CharacterItemPresentRequest>(Request);

    var res = model.Character_ItemPresent(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/character/limit_break")]
public async Task<IActionResult> Character_LimitBreak() {
    var req = await RequestSerializer.Deserialize<CharacterLimitBreakRequest>(Request);

    var res = model.Character_LimitBreak(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/character/rank_enhance")]
public async Task<IActionResult> Character_RankEnhance() {
    var req = await RequestSerializer.Deserialize<CharacterRankEnhanceRequest>(Request);

    var res = model.Character_RankEnhance(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/character/skill_panel_enhance")]
public async Task<IActionResult> Character_SkillPanelEnhance() {
    var req = await RequestSerializer.Deserialize<CharacterSkillPanelEnhanceRequest>(Request);

    var res = model.Character_SkillPanelEnhance(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}


[Route("/character/skill_panel_reset")]
public async Task<IActionResult> Character_SkillPanelReset() {
    var req = await RequestSerializer.Deserialize<CharacterSkillPanelResetRequest>(Request);

    var res = model.Character_SkillPanelReset(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
