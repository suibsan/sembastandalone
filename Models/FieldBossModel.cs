
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FieldBossModel {

public FieldBossEntryResponse? FieldBoss_Entry(FieldBossEntryRequest req) {
    Console.WriteLine($"FieldBoss_Entry: {req}");
    return FieldBossEntryResponse.Parser.ParseJson(
        sembaWrapper.Call("/field_boss/entry", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public FieldBossModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
