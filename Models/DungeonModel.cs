
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class DungeonModel {

public DungeonAcquireAreaItemResponse? Dungeon_AcquireAreaItem(DungeonAcquireAreaItemRequest req) {
    Console.WriteLine($"Dungeon_AcquireAreaItem: {req}");
    return DungeonAcquireAreaItemResponse.Parser.ParseJson(
        sembaWrapper.Call("/dungeon/acquire_area_item", req.ToString())
    );
}


public BattleSkipResponse? Dungeon_BattleSkip(DungeonBattleSkipRequest req) {
    Console.WriteLine($"Dungeon_BattleSkip: {req}");
    return BattleSkipResponse.Parser.ParseJson(
        sembaWrapper.Call("/dungeon/battle_skip", req.ToString())
    );
}


public BattleStartResponse? Dungeon_BattleStart(DungeonBattleStartRequest req) {
    Console.WriteLine($"Dungeon_BattleStart: {req}");
    return BattleStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/dungeon/battle_start", req.ToString())
    );
}


public DungeonEntryResponse? Dungeon_Entry(DungeonEntryRequest req) {
    Console.WriteLine($"Dungeon_Entry: {req}");
    return DungeonEntryResponse.Parser.ParseJson(
        sembaWrapper.Call("/dungeon/entry", req.ToString())
    );
}


public ChangedResourcesResponse? Dungeon_Finish(DungeonFinishRequest req) {
    Console.WriteLine($"Dungeon_Finish: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/dungeon/finish", req.ToString())
    );
}


public DungeonResumeResponse? Dungeon_Resume(DungeonResumeRequest req) {
    Console.WriteLine($"Dungeon_Resume: {req}");
    return DungeonResumeResponse.Parser.ParseJson(
        sembaWrapper.Call("/dungeon/resume", req.ToString())
    );
}


public DungeonStartResponse? Dungeon_Start(DungeonStartRequest req) {
    Console.WriteLine($"Dungeon_Start: {req}");
    return DungeonStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/dungeon/start", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public DungeonModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
