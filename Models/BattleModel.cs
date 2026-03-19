
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class BattleModel {

public BattleFinishResponse? Battle_Finish(BattleFinishRequest req) {
    Console.WriteLine($"Battle_Finish: {req}");
    return BattleFinishResponse.Parser.ParseJson(
        sembaWrapper.Call("/battle/finish", req.ToString())
    );
}


public BattleRestartResponse? Battle_Restart(BattleRestartRequest req) {
    Console.WriteLine($"Battle_Restart: {req}");
    return BattleRestartResponse.Parser.ParseJson(
        sembaWrapper.Call("/battle/restart", req.ToString())
    );
}


public BattleSkipResponse? Battle_Skip(BattleSkipRequest req) {
    Console.WriteLine($"Battle_Skip: {req}");
    return BattleSkipResponse.Parser.ParseJson(
        sembaWrapper.Call("/battle/skip", req.ToString())
    );
}


public BattleStartResponse? Battle_Start(BattleStartRequest req) {
    Console.WriteLine($"Battle_Start: {req}");
    return BattleStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/battle/start", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public BattleModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
