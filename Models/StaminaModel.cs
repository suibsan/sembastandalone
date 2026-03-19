
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class StaminaModel {

public ChangedResourcesResponse? Stamina_Purchase(StaminaPurchaseRequest req) {
    Console.WriteLine($"Stamina_Purchase: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/stamina/purchase", req.ToString())
    );
}


public ChangedResourcesResponse? Stamina_UseItem(StaminaUseItemRequest req) {
    Console.WriteLine($"Stamina_UseItem: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/stamina/use_item", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public StaminaModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
