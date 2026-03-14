
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class RecipeShopModel {

public static ChangedResourcesResponse? RecipeShop_Purchase(RecipeShopPurchaseRequest req) {
    Console.WriteLine($"RecipeShop_Purchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/recipe_shop/purchase", req.ToString())
    );
}

}
