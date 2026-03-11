namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FormationModel {
    public static ChangedResourcesResponse? Formation_Switch(FormationSwitchRequest req) {
        Console.WriteLine($"Formation_Switch: ${req}");
        return ChangedResourcesResponse.Parser.ParseJson(
            SembaWrapper.Call("/formation/switch", req.ToString())
        );
    }

    public static ChangedResourcesResponse? Formation_Update(FormationUpdateRequest req) {
        Console.WriteLine($"Formation_Update: ${req}");
        return ChangedResourcesResponse.Parser.ParseJson(
            SembaWrapper.Call("/formation/update", req.ToString())
        );
    }
}