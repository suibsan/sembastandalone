
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class CityModel {

public ChangedResourcesResponse? City_ReleaseGearShop(CityReleaseGearShopRequest req) {
    Console.WriteLine($"City_ReleaseGearShop: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/city/release_gear_shop", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public CityModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
