
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class CharacterModel {

public ChangedResourcesResponse? Character_CostumeUpdate(CharacterCostumeUpdateRequest req) {
    Console.WriteLine($"Character_CostumeUpdate: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/costume_update", req.ToString())
    );
}


public ChangedResourcesResponse? Character_Enhance(CharacterEnhanceRequest req) {
    Console.WriteLine($"Character_Enhance: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/enhance", req.ToString())
    );
}


public ChangedResourcesResponse? Character_Equip(CharacterEquipRequest req) {
    Console.WriteLine($"Character_Equip: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/equip", req.ToString())
    );
}


public ChangedResourcesResponse? Character_ItemPresent(CharacterItemPresentRequest req) {
    Console.WriteLine($"Character_ItemPresent: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/item_present", req.ToString())
    );
}


public CharacterLimitBreakResponse? Character_LimitBreak(CharacterLimitBreakRequest req) {
    Console.WriteLine($"Character_LimitBreak: {req}");
    return CharacterLimitBreakResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/limit_break", req.ToString())
    );
}


public CharacterRankEnhanceResponse? Character_RankEnhance(CharacterRankEnhanceRequest req) {
    Console.WriteLine($"Character_RankEnhance: {req}");
    return CharacterRankEnhanceResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/rank_enhance", req.ToString())
    );
}


public CharacterSkillPanelEnhanceResponse? Character_SkillPanelEnhance(CharacterSkillPanelEnhanceRequest req) {
    Console.WriteLine($"Character_SkillPanelEnhance: {req}");
    return CharacterSkillPanelEnhanceResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/skill_panel_enhance", req.ToString())
    );
}


public CharacterSkillPanelResetResponse? Character_SkillPanelReset(CharacterSkillPanelResetRequest req) {
    Console.WriteLine($"Character_SkillPanelReset: {req}");
    return CharacterSkillPanelResetResponse.Parser.ParseJson(
        sembaWrapper.Call("/character/skill_panel_reset", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public CharacterModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
