
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class AdventureModel {

public AdventureAccessWarpPointResponse? Adventure_AccessWarpPoint(AdventureAccessWarpPointRequest req) {
    Console.WriteLine($"Adventure_AccessWarpPoint: {req}");
    return AdventureAccessWarpPointResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/access_warp_point", req.ToString())
    );
}


public AdventureAcquireAreaItemResponse? Adventure_AcquireAreaItem(AdventureAcquireAreaItemRequest req) {
    Console.WriteLine($"Adventure_AcquireAreaItem: {req}");
    return AdventureAcquireAreaItemResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/acquire_area_item", req.ToString())
    );
}


public AdventureAreaObjectResponse? Adventure_AreaObject(AdventureAreaObjectRequest req) {
    Console.WriteLine($"Adventure_AreaObject: {req}");
    return AdventureAreaObjectResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/area_object", req.ToString())
    );
}


public AdventureFindGraffitiResponse? Adventure_FindGraffiti(AdventureFindGraffitiRequest req) {
    Console.WriteLine($"Adventure_FindGraffiti: {req}");
    return AdventureFindGraffitiResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/find_graffiti", req.ToString())
    );
}


public ChangedResourcesResponse? Adventure_Hospital(AdventureHospitalRequest req) {
    Console.WriteLine($"Adventure_Hospital: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/hospital", req.ToString())
    );
}


public AdventureMoveToAreaResponse? Adventure_MoveToArea(AdventureMoveToAreaRequest req) {
    Console.WriteLine($"Adventure_MoveToArea: {req}");
    return AdventureMoveToAreaResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/move_to_area", req.ToString())
    );
}


public AdventureReadSequenceResponse? Adventure_ReadSequence(AdventureReadSequenceRequest req) {
    Console.WriteLine($"Adventure_ReadSequence: {req}");
    return AdventureReadSequenceResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/read_sequence", req.ToString())
    );
}


public ChangedResourcesResponse? Adventure_ReleaseEventLift(AdventureReleaseEventLiftRequest req) {
    Console.WriteLine($"Adventure_ReleaseEventLift: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/release_event_lift", req.ToString())
    );
}


public ChangedResourcesResponse? Adventure_TrackTarget(AdventureTrackTargetRequest req) {
    Console.WriteLine($"Adventure_TrackTarget: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/track_target", req.ToString())
    );
}


public ChangedResourcesResponse? Adventure_UpdateCharacterStatus(AdventureUpdateCharacterStatusRequest req) {
    Console.WriteLine($"Adventure_UpdateCharacterStatus: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/update_character_status", req.ToString())
    );
}


public ChangedResourcesResponse? Adventure_WarpAreaLocator(AdventureWarpAreaLocatorRequest req) {
    Console.WriteLine($"Adventure_WarpAreaLocator: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/adventure/warp_area_locator", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public AdventureModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
