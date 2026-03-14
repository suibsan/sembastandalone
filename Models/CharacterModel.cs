
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class CharacterModel {

public static ChangedResourcesResponse? Character_CostumeUpdate(CharacterCostumeUpdateRequest req) {
    Console.WriteLine($"Character_CostumeUpdate: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/costume_update", req.ToString())
    );
}


public static ChangedResourcesResponse? Character_Enhance(CharacterEnhanceRequest req) {
    Console.WriteLine($"Character_Enhance: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/enhance", req.ToString())
    );
}


public static ChangedResourcesResponse? Character_Equip(CharacterEquipRequest req) {
    Console.WriteLine($"Character_Equip: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/equip", req.ToString())
    );
}


public static ChangedResourcesResponse? Character_ItemPresent(CharacterItemPresentRequest req) {
    Console.WriteLine($"Character_ItemPresent: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/item_present", req.ToString())
    );
}


public static CharacterLimitBreakResponse? Character_LimitBreak(CharacterLimitBreakRequest req) {
    Console.WriteLine($"Character_LimitBreak: {req}");
    return CharacterLimitBreakResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/limit_break", req.ToString())
    );
}


public static CharacterRankEnhanceResponse? Character_RankEnhance(CharacterRankEnhanceRequest req) {
    Console.WriteLine($"Character_RankEnhance: {req}");
    return CharacterRankEnhanceResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/rank_enhance", req.ToString())
    );
}


public static CharacterSkillPanelEnhanceResponse? Character_SkillPanelEnhance(CharacterSkillPanelEnhanceRequest req) {
    Console.WriteLine($"Character_SkillPanelEnhance: {req}");
    return CharacterSkillPanelEnhanceResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/skill_panel_enhance", req.ToString())
    );
}


public static CharacterSkillPanelResetResponse? Character_SkillPanelReset(CharacterSkillPanelResetRequest req) {
    Console.WriteLine($"Character_SkillPanelReset: {req}");
    return CharacterSkillPanelResetResponse.Parser.ParseJson(
        SembaWrapper.Call("/character/skill_panel_reset", req.ToString())
    );
}

}
