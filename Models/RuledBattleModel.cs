
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class RuledBattleModel {

public BattleStartResponse? RuledBattle_Start(RuledBattleStartRequest req) {
    Console.WriteLine($"RuledBattle_Start: {req}");
    return BattleStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/ruled_battle/start", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public RuledBattleModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
