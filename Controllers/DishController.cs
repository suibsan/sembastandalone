
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class DishController : Controller {

[Route("/dish/order")]
public async Task<IActionResult> Dish_Order() {
    var req = await RequestSerializer.Deserialize<DishOrderRequest>(Request);

    var res = DishModel.Dish_Order(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
