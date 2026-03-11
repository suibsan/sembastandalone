namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TensionCardModel {
    public static TensionCardLimitBreakEnhanceResponse? TensionCard_LimitBreakEnhance(TensionCardLimitBreakEnhanceRequest req) {
        Console.WriteLine($"TensionCard_LimitBreakEnhance: ${req}");
        return TensionCardLimitBreakEnhanceResponse.Parser.ParseJson(
            SembaWrapper.Call("/tension_card/limit_break_enhance", req.ToString())
        );
    }

    public static ChangedResourcesResponse? TensionCard_Lock(TensionCardLockRequest req) {
        Console.WriteLine($"TensionCard_Lock: ${req}");
        return ChangedResourcesResponse.Parser.ParseJson(
            SembaWrapper.Call("/tension_card/lock", req.ToString())
        );
    }
}