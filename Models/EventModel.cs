
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class EventModel {

public EventFinishNodeResponse? Event_FinishNode(EventFinishNodeRequest req) {
    Console.WriteLine($"Event_FinishNode: {req}");
    return EventFinishNodeResponse.Parser.ParseJson(
        sembaWrapper.Call("/event/finish_node", req.ToString())
    );
}


public ChangedResourcesResponse? Event_ListNode() {
    // no request
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/event/list_node", "")
    );
}


private ISembaWrapper sembaWrapper;

public EventModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
