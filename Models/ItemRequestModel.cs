
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class ItemRequestModel {

public void ItemRequest_Cancel() {
    // no request
    sembaWrapper.Call("/item_request/cancel", "");
}


public ItemRequestCollectResponse? ItemRequest_Collect() {
    // no request
    return ItemRequestCollectResponse.Parser.ParseJson(
        sembaWrapper.Call("/item_request/collect", "")
    );
}


public ItemRequestFulfillResponse? ItemRequest_Fulfill(ItemRequestFulfillRequest req) {
    Console.WriteLine($"ItemRequest_Fulfill: {req}");
    return ItemRequestFulfillResponse.Parser.ParseJson(
        sembaWrapper.Call("/item_request/fulfill", req.ToString())
    );
}


public ItemRequestGetResponse? ItemRequest_Get() {
    // no request
    return ItemRequestGetResponse.Parser.ParseJson(
        sembaWrapper.Call("/item_request/get", "")
    );
}


public ItemRequestListResponse? ItemRequest_List() {
    // no request
    return ItemRequestListResponse.Parser.ParseJson(
        sembaWrapper.Call("/item_request/list", "")
    );
}


public ItemRequestPublishResponse? ItemRequest_Publish(ItemRequestPublishRequest req) {
    Console.WriteLine($"ItemRequest_Publish: {req}");
    return ItemRequestPublishResponse.Parser.ParseJson(
        sembaWrapper.Call("/item_request/publish", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public ItemRequestModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
