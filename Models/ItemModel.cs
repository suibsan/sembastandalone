
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class ItemModel {

public static ChangedResourcesResponse? Item_Exchange(ItemExchangeRequest req) {
    Console.WriteLine($"Item_Exchange: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/item/exchange", req.ToString())
    );
}


public static ChangedResourcesResponse? Item_OpenSelectBox(ItemOpenSelectBoxRequest req) {
    Console.WriteLine($"Item_OpenSelectBox: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/item/open_select_box", req.ToString())
    );
}


public static ChangedResourcesResponse? Item_Sell(ItemSellRequest req) {
    Console.WriteLine($"Item_Sell: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/item/sell", req.ToString())
    );
}


public static ChangedResourcesResponse? Item_Synthesize(ItemSynthesizeRequest req) {
    Console.WriteLine($"Item_Synthesize: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/item/synthesize", req.ToString())
    );
}


public static ChangedResourcesResponse? Item_UseSupply(ItemUseSupplyRequest req) {
    Console.WriteLine($"Item_UseSupply: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/item/use_supply", req.ToString())
    );
}


public static ChangedResourcesResponse? Item_UseSupplyGearEffect(ItemUseSupplyGearEffectRequest req) {
    Console.WriteLine($"Item_UseSupplyGearEffect: {req}");
    return ChangedResourcesResponse.Parser.ParseJson(
        SembaWrapper.Call("/item/use_supply_gear_effect", req.ToString())
    );
}

}
