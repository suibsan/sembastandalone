
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class EventModel {

public static EventFinishNodeResponse? Event_FinishNode(EventFinishNodeRequest req) {
    Console.WriteLine($"Event_FinishNode: {req}");
    return EventFinishNodeResponse.Parser.ParseJson(
        SembaWrapper.Call("/event/finish_node", req.ToString())
    );
}


public static ChangedResourcesResponse? Event_ListNode() {
    // no request
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/event/list_node", "")
    );
}

}
