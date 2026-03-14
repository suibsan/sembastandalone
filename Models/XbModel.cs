
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class XbModel {

public static XbAddCommandUnlockItemResponse? Xb_AddCommandUnlockItem(XbAddCommandUnlockItemRequest req) {
    Console.WriteLine($"Xb_AddCommandUnlockItem: {req}");
    return XbAddCommandUnlockItemResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/add_command_unlock_item", req.ToString())
    );
}


public static void Xb_ForceRetire() {
    // no request
    SembaWrapper.Call("/xb/force_retire", "");
}


public static XbFormationResponse? Xb_Formation(XbFormationRequest req) {
    Console.WriteLine($"Xb_Formation: {req}");
    return XbFormationResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/formation", req.ToString())
    );
}


public static XbFormationUpdateResponse? Xb_FormationUpdate(XbFormationUpdateRequest req) {
    Console.WriteLine($"Xb_FormationUpdate: {req}");
    return XbFormationUpdateResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/formation_update", req.ToString())
    );
}


public static XbPlayResponse? Xb_Play(XbPlayRequest req) {
    Console.WriteLine($"Xb_Play: {req}");
    return XbPlayResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/play", req.ToString())
    );
}


public static XbRetireResponse? Xb_Retire() {
    // no request
    return XbRetireResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/retire", "")
    );
}


public static XbStartResponse? Xb_Start(XbStartRequest req) {
    Console.WriteLine($"Xb_Start: {req}");
    return XbStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/start", req.ToString())
    );
}


public static XbStatusResponse? Xb_Status(XbStatusRequest req) {
    Console.WriteLine($"Xb_Status: {req}");
    return XbStatusResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/status", req.ToString())
    );
}


public static XbUpdateSkillOrbStatusResponse? Xb_UpdateSkillOrbStatus(XbUpdateSkillOrbStatusRequest req) {
    Console.WriteLine($"Xb_UpdateSkillOrbStatus: {req}");
    return XbUpdateSkillOrbStatusResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/update_skill_orb_status", req.ToString())
    );
}


public static XbUpdateTensionResponse? Xb_UpdateTension(XbUpdateTensionRequest req) {
    Console.WriteLine($"Xb_UpdateTension: {req}");
    return XbUpdateTensionResponse.Parser.ParseJson(
        SembaWrapper.Call("/xb/update_tension", req.ToString())
    );
}

}
