
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class RuledBattleModel {

public static BattleStartResponse? RuledBattle_Start(RuledBattleStartRequest req) {
    Console.WriteLine($"RuledBattle_Start: {req}");
    return BattleStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/ruled_battle/start", req.ToString())
    );
}

}
