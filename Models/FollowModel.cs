
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class FollowModel {

public static FollowAddResponse? Follow_Add(FollowAddRequest req) {
    Console.WriteLine($"Follow_Add: {req}");
    return FollowAddResponse.Parser.ParseJson(
        SembaWrapper.Call("/follow/add", req.ToString())
    );
}


public static FollowDetailResponse? Follow_Detail(FollowDetailRequest req) {
    Console.WriteLine($"Follow_Detail: {req}");
    return FollowDetailResponse.Parser.ParseJson(
        SembaWrapper.Call("/follow/detail", req.ToString())
    );
}


public static FollowListResponse? Follow_List() {
    // no request
    return FollowListResponse.Parser.ParseJson(
        SembaWrapper.Call("/follow/list", "")
    );
}


public static FollowRemoveResponse? Follow_Remove(FollowRemoveRequest req) {
    Console.WriteLine($"Follow_Remove: {req}");
    return FollowRemoveResponse.Parser.ParseJson(
        SembaWrapper.Call("/follow/remove", req.ToString())
    );
}


public static FollowSearchResponse? Follow_Search(FollowSearchRequest req) {
    Console.WriteLine($"Follow_Search: {req}");
    return FollowSearchResponse.Parser.ParseJson(
        SembaWrapper.Call("/follow/search", req.ToString())
    );
}

}
