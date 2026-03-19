
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class XbPvpModel {

public XbPvpCasualMatchingResponse? XbPvp_CasualMatching(XbPvpCasualMatchingRequest req) {
    Console.WriteLine($"XbPvp_CasualMatching: {req}");
    return XbPvpCasualMatchingResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb_pvp/casual_matching", req.ToString())
    );
}


public XbPvpEntryResponse? XbPvp_Entry() {
    // no request
    return XbPvpEntryResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb_pvp/entry", "")
    );
}


public XbPvpFormationResponse? XbPvp_Formation() {
    // no request
    return XbPvpFormationResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb_pvp/formation", "")
    );
}


public XbPvpFormationUpdateResponse? XbPvp_FormationUpdate(XbPvpFormationUpdateRequest req) {
    Console.WriteLine($"XbPvp_FormationUpdate: {req}");
    return XbPvpFormationUpdateResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb_pvp/formation_update", req.ToString())
    );
}


public XbPvpQuickMatchingResponse? XbPvp_QuickMatching() {
    // no request
    return XbPvpQuickMatchingResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb_pvp/quick_matching", "")
    );
}


public XbPvpRankMatchHistoryListResponse? XbPvp_RankMatchHistoryList(XbPvpRankMatchHistoryListRequest req) {
    Console.WriteLine($"XbPvp_RankMatchHistoryList: {req}");
    return XbPvpRankMatchHistoryListResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb_pvp/rank_match_history_list", req.ToString())
    );
}


public XbPvpRankMatchingResponse? XbPvp_RankMatching() {
    // no request
    return XbPvpRankMatchingResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb_pvp/rank_matching", "")
    );
}


private ISembaWrapper sembaWrapper;

public XbPvpModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
