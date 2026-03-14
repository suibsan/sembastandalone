
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class XbPvpModel {

public static XbPvpCasualMatchingResponse? XbPvp_CasualMatching(XbPvpCasualMatchingRequest req) {
    Console.WriteLine($"XbPvp_CasualMatching: {req}");
    return XbPvpCasualMatchingResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb_pvp/casual_matching", req.ToString())
    );
}


public static XbPvpEntryResponse? XbPvp_Entry() {
    // no request
    return XbPvpEntryResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb_pvp/entry", "")
    );
}


public static XbPvpFormationResponse? XbPvp_Formation() {
    // no request
    return XbPvpFormationResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb_pvp/formation", "")
    );
}


public static XbPvpFormationUpdateResponse? XbPvp_FormationUpdate(XbPvpFormationUpdateRequest req) {
    Console.WriteLine($"XbPvp_FormationUpdate: {req}");
    return XbPvpFormationUpdateResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb_pvp/formation_update", req.ToString())
    );
}


public static XbPvpQuickMatchingResponse? XbPvp_QuickMatching() {
    // no request
    return XbPvpQuickMatchingResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb_pvp/quick_matching", "")
    );
}


public static XbPvpRankMatchHistoryListResponse? XbPvp_RankMatchHistoryList(XbPvpRankMatchHistoryListRequest req) {
    Console.WriteLine($"XbPvp_RankMatchHistoryList: {req}");
    return XbPvpRankMatchHistoryListResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb_pvp/rank_match_history_list", req.ToString())
    );
}


public static XbPvpRankMatchingResponse? XbPvp_RankMatching() {
    // no request
    return XbPvpRankMatchingResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb_pvp/rank_matching", "")
    );
}

}
