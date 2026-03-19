
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class XbModel {

public XbAddCommandUnlockItemResponse? Xb_AddCommandUnlockItem(XbAddCommandUnlockItemRequest req) {
    Console.WriteLine($"Xb_AddCommandUnlockItem: {req}");
    return XbAddCommandUnlockItemResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/add_command_unlock_item", req.ToString())
    );
}


public void Xb_ForceRetire() {
    // no request
    sembaWrapper.Call("/xb/force_retire", "");
}


public XbFormationResponse? Xb_Formation(XbFormationRequest req) {
    Console.WriteLine($"Xb_Formation: {req}");
    return XbFormationResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/formation", req.ToString())
    );
}


public XbFormationUpdateResponse? Xb_FormationUpdate(XbFormationUpdateRequest req) {
    Console.WriteLine($"Xb_FormationUpdate: {req}");
    return XbFormationUpdateResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/formation_update", req.ToString())
    );
}


public XbPlayResponse? Xb_Play(XbPlayRequest req) {
    Console.WriteLine($"Xb_Play: {req}");
    return XbPlayResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/play", req.ToString())
    );
}


public XbRetireResponse? Xb_Retire() {
    // no request
    return XbRetireResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/retire", "")
    );
}


public XbStartResponse? Xb_Start(XbStartRequest req) {
    Console.WriteLine($"Xb_Start: {req}");
    return XbStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/start", req.ToString())
    );
}


public XbStatusResponse? Xb_Status(XbStatusRequest req) {
    Console.WriteLine($"Xb_Status: {req}");
    return XbStatusResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/status", req.ToString())
    );
}


public XbUpdateSkillOrbStatusResponse? Xb_UpdateSkillOrbStatus(XbUpdateSkillOrbStatusRequest req) {
    Console.WriteLine($"Xb_UpdateSkillOrbStatus: {req}");
    return XbUpdateSkillOrbStatusResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/update_skill_orb_status", req.ToString())
    );
}


public XbUpdateTensionResponse? Xb_UpdateTension(XbUpdateTensionRequest req) {
    Console.WriteLine($"Xb_UpdateTension: {req}");
    return XbUpdateTensionResponse.Parser.ParseJson(
        sembaWrapper.Call("/xb/update_tension", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public XbModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
