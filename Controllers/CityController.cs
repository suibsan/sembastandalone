
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class CityController : Controller {

[Route("/city/release_gear_shop")]
public async Task<IActionResult> City_ReleaseGearShop() {
    var req = await RequestSerializer.Deserialize<CityReleaseGearShopRequest>(Request);

    var res = CityModel.City_ReleaseGearShop(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
