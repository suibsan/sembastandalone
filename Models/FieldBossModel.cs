
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FieldBossModel {

public static FieldBossEntryResponse? FieldBoss_Entry(FieldBossEntryRequest req) {
    Console.WriteLine($"FieldBoss_Entry: {req}");
    return FieldBossEntryResponse.Parser.ParseJson(
        SembaWrapper.Call("/field_boss/entry", req.ToString())
    );
}

}
