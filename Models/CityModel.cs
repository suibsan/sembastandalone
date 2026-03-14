
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class CityModel {

public static ChangedResourcesResponse? City_ReleaseGearShop(CityReleaseGearShopRequest req) {
    Console.WriteLine($"City_ReleaseGearShop: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/city/release_gear_shop", req.ToString())
    );
}

}
