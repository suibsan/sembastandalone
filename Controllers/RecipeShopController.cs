
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class RecipeShopController : Controller {

private RecipeShopModel model;

public RecipeShopController(ISembaWrapper wrapper) {
    model = new RecipeShopModel(wrapper);
}


[Route("/recipe_shop/purchase")]
public async Task<IActionResult> RecipeShop_Purchase() {
    var req = await RequestSerializer.Deserialize<RecipeShopPurchaseRequest>(Request);

    var res = model.RecipeShop_Purchase(req);

    if (res == null) {
        return StatusCode(500);
    }

    return RequestSerializer.Serialize(res);
}

}
