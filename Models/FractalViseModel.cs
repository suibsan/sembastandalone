
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FractalViseModel {

public static FractalViseAcquireAreaItemResponse? FractalVise_AcquireAreaItem(FractalViseAcquireAreaItemRequest req) {
    Console.WriteLine($"FractalVise_AcquireAreaItem: {req}");
    return FractalViseAcquireAreaItemResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/acquire_area_item", req.ToString())
    );
}


public static BattleStartResponse? FractalVise_BattleStart(FractalViseBattleStartRequest req) {
    Console.WriteLine($"FractalVise_BattleStart: {req}");
    return BattleStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/battle_start", req.ToString())
    );
}


public static BattleStartResponse? FractalVise_BattleStartBossBattle(FractalViseBattleStartBossBattleRequest req) {
    Console.WriteLine($"FractalVise_BattleStartBossBattle: {req}");
    return BattleStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/battle_start_boss_battle", req.ToString())
    );
}


public static FractalViseBossDifficultyResponse? FractalVise_BossDifficulty(FractalViseBossDifficultyRequest req) {
    Console.WriteLine($"FractalVise_BossDifficulty: {req}");
    return FractalViseBossDifficultyResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/boss_difficulty", req.ToString())
    );
}


public static FractalViseClearResponse? FractalVise_Clear(FractalViseClearRequest req) {
    Console.WriteLine($"FractalVise_Clear: {req}");
    return FractalViseClearResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/clear", req.ToString())
    );
}


public static FractalViseNextAreaResponse? FractalVise_NextArea(FractalViseNextAreaRequest req) {
    Console.WriteLine($"FractalVise_NextArea: {req}");
    return FractalViseNextAreaResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/next_area", req.ToString())
    );
}


public static FractalViseResumeResponse? FractalVise_Resume(FractalViseResumeRequest req) {
    Console.WriteLine($"FractalVise_Resume: {req}");
    return FractalViseResumeResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/resume", req.ToString())
    );
}


public static FractalViseRetireResponse? FractalVise_Retire(FractalViseRetireRequest req) {
    Console.WriteLine($"FractalVise_Retire: {req}");
    return FractalViseRetireResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/retire", req.ToString())
    );
}


public static FractalViseRewardsReceiveResponse? FractalVise_RewardsReceive(FractalViseRewardsReceiveRequest req) {
    Console.WriteLine($"FractalVise_RewardsReceive: {req}");
    return FractalViseRewardsReceiveResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/rewards_receive", req.ToString())
    );
}


public static FractalViseRewardsTopResponse? FractalVise_RewardsTop(FractalViseRewardsTopRequest req) {
    Console.WriteLine($"FractalVise_RewardsTop: {req}");
    return FractalViseRewardsTopResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/rewards_top", req.ToString())
    );
}


public static FractalViseStartResponse? FractalVise_Start(FractalViseStartRequest req) {
    Console.WriteLine($"FractalVise_Start: {req}");
    return FractalViseStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/fractal_vise/start", req.ToString())
    );
}

}
