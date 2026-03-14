
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class StaminaModel {

public static ChangedResourcesResponse? Stamina_Purchase(StaminaPurchaseRequest req) {
    Console.WriteLine($"Stamina_Purchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/stamina/purchase", req.ToString())
    );
}


public static ChangedResourcesResponse? Stamina_UseItem(StaminaUseItemRequest req) {
    Console.WriteLine($"Stamina_UseItem: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/stamina/use_item", req.ToString())
    );
}

}
