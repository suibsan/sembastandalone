
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FormationModel {

public ChangedResourcesResponse? Formation_Switch(FormationSwitchRequest req) {
    Console.WriteLine($"Formation_Switch: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/formation/switch", req.ToString())
    );
}


public ChangedResourcesResponse? Formation_Update(FormationUpdateRequest req) {
    Console.WriteLine($"Formation_Update: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/formation/update", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public FormationModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
