
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class DishModel {

public ChangedResourcesResponse? Dish_Order(DishOrderRequest req) {
    Console.WriteLine($"Dish_Order: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/dish/order", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public DishModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
