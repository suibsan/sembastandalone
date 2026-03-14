
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class DishModel {

public static ChangedResourcesResponse? Dish_Order(DishOrderRequest req) {
    Console.WriteLine($"Dish_Order: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/dish/order", req.ToString())
    );
}

}
