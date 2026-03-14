
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TrialBattleModel {

public static TrialBattleRewardReceiveResponse? TrialBattle_RewardReceive(TrialBattleRewardReceiveRequest req) {
    Console.WriteLine($"TrialBattle_RewardReceive: {req}");
    return TrialBattleRewardReceiveResponse.Parser.ParseJson(
        SembaWrapper.Call("/trial_battle/reward_receive", req.ToString())
    );
}


public static BattleStartResponse? TrialBattle_Start(TrialBattleStartRequest req) {
    Console.WriteLine($"TrialBattle_Start: {req}");
    return BattleStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/trial_battle/start", req.ToString())
    );
}

}
