
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FractalViseModel {

public FractalViseAcquireAreaItemResponse? FractalVise_AcquireAreaItem(FractalViseAcquireAreaItemRequest req) {
    Console.WriteLine($"FractalVise_AcquireAreaItem: {req}");
    return FractalViseAcquireAreaItemResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/acquire_area_item", req.ToString())
    );
}


public BattleStartResponse? FractalVise_BattleStart(FractalViseBattleStartRequest req) {
    Console.WriteLine($"FractalVise_BattleStart: {req}");
    return BattleStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/battle_start", req.ToString())
    );
}


public BattleStartResponse? FractalVise_BattleStartBossBattle(FractalViseBattleStartBossBattleRequest req) {
    Console.WriteLine($"FractalVise_BattleStartBossBattle: {req}");
    return BattleStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/battle_start_boss_battle", req.ToString())
    );
}


public FractalViseBossDifficultyResponse? FractalVise_BossDifficulty(FractalViseBossDifficultyRequest req) {
    Console.WriteLine($"FractalVise_BossDifficulty: {req}");
    return FractalViseBossDifficultyResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/boss_difficulty", req.ToString())
    );
}


public FractalViseClearResponse? FractalVise_Clear(FractalViseClearRequest req) {
    Console.WriteLine($"FractalVise_Clear: {req}");
    return FractalViseClearResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/clear", req.ToString())
    );
}


public FractalViseNextAreaResponse? FractalVise_NextArea(FractalViseNextAreaRequest req) {
    Console.WriteLine($"FractalVise_NextArea: {req}");
    return FractalViseNextAreaResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/next_area", req.ToString())
    );
}


public FractalViseResumeResponse? FractalVise_Resume(FractalViseResumeRequest req) {
    Console.WriteLine($"FractalVise_Resume: {req}");
    return FractalViseResumeResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/resume", req.ToString())
    );
}


public FractalViseRetireResponse? FractalVise_Retire(FractalViseRetireRequest req) {
    Console.WriteLine($"FractalVise_Retire: {req}");
    return FractalViseRetireResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/retire", req.ToString())
    );
}


public FractalViseRewardsReceiveResponse? FractalVise_RewardsReceive(FractalViseRewardsReceiveRequest req) {
    Console.WriteLine($"FractalVise_RewardsReceive: {req}");
    return FractalViseRewardsReceiveResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/rewards_receive", req.ToString())
    );
}


public FractalViseRewardsTopResponse? FractalVise_RewardsTop(FractalViseRewardsTopRequest req) {
    Console.WriteLine($"FractalVise_RewardsTop: {req}");
    return FractalViseRewardsTopResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/rewards_top", req.ToString())
    );
}


public FractalViseStartResponse? FractalVise_Start(FractalViseStartRequest req) {
    Console.WriteLine($"FractalVise_Start: {req}");
    return FractalViseStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/fractal_vise/start", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public FractalViseModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
