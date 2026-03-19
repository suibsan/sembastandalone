
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class NewsModel {

public NewsListResponse? News_List(NewsListRequest req) {
    Console.WriteLine($"News_List: {req}");
    return NewsListResponse.Parser.ParseJson(
        sembaWrapper.Call("/news/list", req.ToString())
    );
}


public NewsUserListResponse? News_UserList() {
    // no request
    return NewsUserListResponse.Parser.ParseJson(
        sembaWrapper.Call("/news/user_list", "")
    );
}


private ISembaWrapper sembaWrapper;

public NewsModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
