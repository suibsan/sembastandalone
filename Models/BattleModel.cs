
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class BattleModel {

public static BattleFinishResponse? Battle_Finish(BattleFinishRequest req) {
    Console.WriteLine($"Battle_Finish: {req}");
    return BattleFinishResponse.Parser.ParseJson(
        SembaWrapper.Call("/battle/finish", req.ToString())
    );
}


public static BattleRestartResponse? Battle_Restart(BattleRestartRequest req) {
    Console.WriteLine($"Battle_Restart: {req}");
    return BattleRestartResponse.Parser.ParseJson(
        SembaWrapper.Call("/battle/restart", req.ToString())
    );
}


public static BattleSkipResponse? Battle_Skip(BattleSkipRequest req) {
    Console.WriteLine($"Battle_Skip: {req}");
    return BattleSkipResponse.Parser.ParseJson(
        SembaWrapper.Call("/battle/skip", req.ToString())
    );
}


public static BattleStartResponse? Battle_Start(BattleStartRequest req) {
    Console.WriteLine($"Battle_Start: {req}");
    return BattleStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/battle/start", req.ToString())
    );
}

}
