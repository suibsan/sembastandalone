
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class DishController : Controller {

private DishModel model;

public DishController(ISembaWrapper wrapper) {
    model = new DishModel(wrapper);
}


[Route("/dish/order")]
public async Task<IActionResult> Dish_Order() {
    var req = await RequestSerializer.Deserialize<DishOrderRequest>(Request);

    var res = model.Dish_Order(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
