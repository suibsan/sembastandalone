namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class CharacterModel {
    public static ChangedResourcesResponse? Character_CostumeUpdate(CharacterCostumeUpdateRequest req) {
        Console.WriteLine($"Character_CostumeUpdate: ${req}");
        return ChangedResourcesResponse.Parser.ParseJson(
            SembaWrapper.Call("/character/costume_update", req.ToString())
        );
    }

    public static CharacterLimitBreakResponse? Character_LimitBreak(CharacterLimitBreakRequest req) {
        Console.WriteLine($"Character_LimitBreak: ${req}");
        return CharacterLimitBreakResponse.Parser.ParseJson(
            SembaWrapper.Call("/character/limit_break", req.ToString())
        );
    }
}