
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class GearModel {

public GearCompressResponse? Gear_Compress(GearCompressRequest req) {
    Console.WriteLine($"Gear_Compress: {req}");
    return GearCompressResponse.Parser.ParseJson(
        sembaWrapper.Call("/gear/compress", req.ToString())
    );
}


public ChangedResourcesResponse? Gear_Lock(GearLockRequest req) {
    Console.WriteLine($"Gear_Lock: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/gear/lock", req.ToString())
    );
}


public ChangedResourcesResponse? Gear_Unlock(GearUnlockRequest req) {
    Console.WriteLine($"Gear_Unlock: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/gear/unlock", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public GearModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
