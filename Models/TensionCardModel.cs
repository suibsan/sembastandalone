
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TensionCardModel {

public TensionCardDisassembleResponse? TensionCard_Disassemble(TensionCardDisassembleRequest req) {
    Console.WriteLine($"TensionCard_Disassemble: {req}");
    return TensionCardDisassembleResponse.Parser.ParseJson(
        sembaWrapper.Call("/tension_card/disassemble", req.ToString())
    );
}


public ChangedResourcesResponse? TensionCard_Enhance(TensionCardEnhanceRequest req) {
    Console.WriteLine($"TensionCard_Enhance: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/tension_card/enhance", req.ToString())
    );
}


public ChangedResourcesResponse? TensionCard_LevelLimitEnhance(TensionCardLevelLimitEnhanceRequest req) {
    Console.WriteLine($"TensionCard_LevelLimitEnhance: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/tension_card/level_limit_enhance", req.ToString())
    );
}


public TensionCardLimitBreakEnhanceResponse? TensionCard_LimitBreakEnhance(TensionCardLimitBreakEnhanceRequest req) {
    Console.WriteLine($"TensionCard_LimitBreakEnhance: {req}");
    return TensionCardLimitBreakEnhanceResponse.Parser.ParseJson(
        sembaWrapper.Call("/tension_card/limit_break_enhance", req.ToString())
    );
}


public ChangedResourcesResponse? TensionCard_Lock(TensionCardLockRequest req) {
    Console.WriteLine($"TensionCard_Lock: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/tension_card/lock", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public TensionCardModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
