namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class DungeonModel {
    public static BattleStartResponse? Dungeon_BattleStart(DungeonBattleStartRequest req) {
        Console.WriteLine($"Dungeon_BattleStart: ${req}");
        return BattleStartResponse.Parser.ParseJson(
            SembaWrapper.Call("/dungeon/battle_start", req.ToString())
        );
    }

    public static DungeonEntryResponse? Dungeon_Entry(DungeonEntryRequest req) {
        Console.WriteLine($"Dungeon_Entry: ${req}");
        return DungeonEntryResponse.Parser.ParseJson(
            SembaWrapper.Call("/dungeon/entry", req.ToString())
        );
    }

    public static ChangedResourcesResponse? Dungeon_Finish(DungeonFinishRequest req) {
        Console.WriteLine($"Dungeon_Finish: ${req}");
        return ChangedResourcesResponse.Parser.ParseJson(
            SembaWrapper.Call("/dungeon/finish", req.ToString())
        );
    }

    public static DungeonResumeResponse? Dungeon_Resume(DungeonResumeRequest req) {
        Console.WriteLine($"Dungeon_Resume: ${req}");
        return DungeonResumeResponse.Parser.ParseJson(
            SembaWrapper.Call("/dungeon/resume", req.ToString())
        );
    }

    public static DungeonStartResponse? Dungeon_Start(DungeonStartRequest req) {
        Console.WriteLine($"Dungeon_Start: ${req}");
        return DungeonStartResponse.Parser.ParseJson(
            SembaWrapper.Call("/dungeon/start", req.ToString())
        );
    }
}