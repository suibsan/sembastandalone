
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class AdventureModel {

public static AdventureAccessWarpPointResponse? Adventure_AccessWarpPoint(AdventureAccessWarpPointRequest req) {
    Console.WriteLine($"Adventure_AccessWarpPoint: {req}");
    return AdventureAccessWarpPointResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/access_warp_point", req.ToString())
    );
}


public static AdventureAcquireAreaItemResponse? Adventure_AcquireAreaItem(AdventureAcquireAreaItemRequest req) {
    Console.WriteLine($"Adventure_AcquireAreaItem: {req}");
    return AdventureAcquireAreaItemResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/acquire_area_item", req.ToString())
    );
}


public static AdventureAreaObjectResponse? Adventure_AreaObject(AdventureAreaObjectRequest req) {
    Console.WriteLine($"Adventure_AreaObject: {req}");
    return AdventureAreaObjectResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/area_object", req.ToString())
    );
}


public static AdventureFindGraffitiResponse? Adventure_FindGraffiti(AdventureFindGraffitiRequest req) {
    Console.WriteLine($"Adventure_FindGraffiti: {req}");
    return AdventureFindGraffitiResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/find_graffiti", req.ToString())
    );
}


public static ChangedResourcesResponse? Adventure_Hospital(AdventureHospitalRequest req) {
    Console.WriteLine($"Adventure_Hospital: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/hospital", req.ToString())
    );
}


public static AdventureMoveToAreaResponse? Adventure_MoveToArea(AdventureMoveToAreaRequest req) {
    Console.WriteLine($"Adventure_MoveToArea: {req}");
    return AdventureMoveToAreaResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/move_to_area", req.ToString())
    );
}


public static AdventureReadSequenceResponse? Adventure_ReadSequence(AdventureReadSequenceRequest req) {
    Console.WriteLine($"Adventure_ReadSequence: {req}");
    return AdventureReadSequenceResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/read_sequence", req.ToString())
    );
}


public static ChangedResourcesResponse? Adventure_ReleaseEventLift(AdventureReleaseEventLiftRequest req) {
    Console.WriteLine($"Adventure_ReleaseEventLift: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/release_event_lift", req.ToString())
    );
}


public static ChangedResourcesResponse? Adventure_TrackTarget(AdventureTrackTargetRequest req) {
    Console.WriteLine($"Adventure_TrackTarget: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/track_target", req.ToString())
    );
}


public static ChangedResourcesResponse? Adventure_UpdateCharacterStatus(AdventureUpdateCharacterStatusRequest req) {
    Console.WriteLine($"Adventure_UpdateCharacterStatus: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/update_character_status", req.ToString())
    );
}


public static ChangedResourcesResponse? Adventure_WarpAreaLocator(AdventureWarpAreaLocatorRequest req) {
    Console.WriteLine($"Adventure_WarpAreaLocator: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/adventure/warp_area_locator", req.ToString())
    );
}

}
