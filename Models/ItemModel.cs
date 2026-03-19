
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class ItemModel {

public ChangedResourcesResponse? Item_Exchange(ItemExchangeRequest req) {
    Console.WriteLine($"Item_Exchange: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/item/exchange", req.ToString())
    );
}


public ChangedResourcesResponse? Item_OpenSelectBox(ItemOpenSelectBoxRequest req) {
    Console.WriteLine($"Item_OpenSelectBox: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/item/open_select_box", req.ToString())
    );
}


public ChangedResourcesResponse? Item_Sell(ItemSellRequest req) {
    Console.WriteLine($"Item_Sell: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/item/sell", req.ToString())
    );
}


public ChangedResourcesResponse? Item_Synthesize(ItemSynthesizeRequest req) {
    Console.WriteLine($"Item_Synthesize: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/item/synthesize", req.ToString())
    );
}


public ChangedResourcesResponse? Item_UseSupply(ItemUseSupplyRequest req) {
    Console.WriteLine($"Item_UseSupply: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/item/use_supply", req.ToString())
    );
}


public ChangedResourcesResponse? Item_UseSupplyGearEffect(ItemUseSupplyGearEffectRequest req) {
    Console.WriteLine($"Item_UseSupplyGearEffect: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        sembaWrapper.Call("/item/use_supply_gear_effect", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public ItemModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
