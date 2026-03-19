
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TrialBattleModel {

public TrialBattleRewardReceiveResponse? TrialBattle_RewardReceive(TrialBattleRewardReceiveRequest req) {
    Console.WriteLine($"TrialBattle_RewardReceive: {req}");
    return TrialBattleRewardReceiveResponse.Parser.ParseJson(
        sembaWrapper.Call("/trial_battle/reward_receive", req.ToString())
    );
}


public BattleStartResponse? TrialBattle_Start(TrialBattleStartRequest req) {
    Console.WriteLine($"TrialBattle_Start: {req}");
    return BattleStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/trial_battle/start", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public TrialBattleModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
