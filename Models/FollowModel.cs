
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FollowModel {

public FollowAddResponse? Follow_Add(FollowAddRequest req) {
    Console.WriteLine($"Follow_Add: {req}");
    return FollowAddResponse.Parser.ParseJson(
        sembaWrapper.Call("/follow/add", req.ToString())
    );
}


public FollowDetailResponse? Follow_Detail(FollowDetailRequest req) {
    Console.WriteLine($"Follow_Detail: {req}");
    return FollowDetailResponse.Parser.ParseJson(
        sembaWrapper.Call("/follow/detail", req.ToString())
    );
}


public FollowListResponse? Follow_List() {
    // no request
    return FollowListResponse.Parser.ParseJson(
        sembaWrapper.Call("/follow/list", "")
    );
}


public FollowRemoveResponse? Follow_Remove(FollowRemoveRequest req) {
    Console.WriteLine($"Follow_Remove: {req}");
    return FollowRemoveResponse.Parser.ParseJson(
        sembaWrapper.Call("/follow/remove", req.ToString())
    );
}


public FollowSearchResponse? Follow_Search(FollowSearchRequest req) {
    Console.WriteLine($"Follow_Search: {req}");
    return FollowSearchResponse.Parser.ParseJson(
        sembaWrapper.Call("/follow/search", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public FollowModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
