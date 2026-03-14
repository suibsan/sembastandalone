
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class NewsModel {

public static NewsListResponse? News_List(NewsListRequest req) {
    Console.WriteLine($"News_List: {req}");
    return NewsListResponse.Parser.ParseJson(
        SembaWrapper.Call("/news/list", req.ToString())
    );
}


public static NewsUserListResponse? News_UserList() {
    // no request
    return NewsUserListResponse.Parser.ParseJson(
        SembaWrapper.Call("/news/user_list", "")
    );
}

}
