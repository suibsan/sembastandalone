
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class RecipeShopModel {

public ChangedResourcesResponse? RecipeShop_Purchase(RecipeShopPurchaseRequest req) {
    Console.WriteLine($"RecipeShop_Purchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/recipe_shop/purchase", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public RecipeShopModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
