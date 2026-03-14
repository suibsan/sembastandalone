
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class ItemRequestModel {

public static void ItemRequest_Cancel() {
    // no request
    SembaWrapper.Call("/item_request/cancel", "");
}


public static ItemRequestCollectResponse? ItemRequest_Collect() {
    // no request
    return ItemRequestCollectResponse.Parser.ParseJson(
        SembaWrapper.Call("/item_request/collect", "")
    );
}


public static ItemRequestFulfillResponse? ItemRequest_Fulfill(ItemRequestFulfillRequest req) {
    Console.WriteLine($"ItemRequest_Fulfill: {req}");
    return ItemRequestFulfillResponse.Parser.ParseJson(
        SembaWrapper.Call("/item_request/fulfill", req.ToString())
    );
}


public static ItemRequestGetResponse? ItemRequest_Get() {
    // no request
    return ItemRequestGetResponse.Parser.ParseJson(
        SembaWrapper.Call("/item_request/get", "")
    );
}


public static ItemRequestListResponse? ItemRequest_List() {
    // no request
    return ItemRequestListResponse.Parser.ParseJson(
        SembaWrapper.Call("/item_request/list", "")
    );
}


public static ItemRequestPublishResponse? ItemRequest_Publish(ItemRequestPublishRequest req) {
    Console.WriteLine($"ItemRequest_Publish: {req}");
    return ItemRequestPublishResponse.Parser.ParseJson(
        SembaWrapper.Call("/item_request/publish", req.ToString())
    );
}

}
