namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class XbModel {
    public static XbFormationResponse? Xb_Formation(XbFormationRequest req) {
        Console.WriteLine($"Xb_Formation: ${req}");
        return XbFormationResponse.Parser.ParseJson(
            SembaWrapper.Call("/xb/formation", req.ToString())
        );
    }

    public static XbPlayResponse? Xb_Play(XbPlayRequest req) {
        Console.WriteLine($"Xb_Play: ${req}");
        return XbPlayResponse.Parser.ParseJson(
            SembaWrapper.Call("/xb/play", req.ToString())
        );
    }

    public static XbStartResponse? Xb_Start(XbStartRequest req) {
        Console.WriteLine($"Xb_Start: ${req}");
        return XbStartResponse.Parser.ParseJson(
            SembaWrapper.Call("/xb/start", req.ToString())
        );
    }

    public static XbUpdateTensionResponse? Xb_UpdateTension(XbUpdateTensionRequest req) {
        Console.WriteLine($"Xb_UpdateTension: ${req}");
        return XbUpdateTensionResponse.Parser.ParseJson(
            SembaWrapper.Call("/xb/update_tension", req.ToString())
        );
    }
}