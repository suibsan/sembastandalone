
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class GearModel {

public static GearCompressResponse? Gear_Compress(GearCompressRequest req) {
    Console.WriteLine($"Gear_Compress: {req}");
    return GearCompressResponse.Parser.ParseJson(
        SembaWrapper.Call("/gear/compress", req.ToString())
    );
}


public static ChangedResourcesResponse? Gear_Lock(GearLockRequest req) {
    Console.WriteLine($"Gear_Lock: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/gear/lock", req.ToString())
    );
}


public static ChangedResourcesResponse? Gear_Unlock(GearUnlockRequest req) {
    Console.WriteLine($"Gear_Unlock: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/gear/unlock", req.ToString())
    );
}

}
