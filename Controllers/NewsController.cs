using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;
using sembastandalone.Models;
using Neon.Model.Api.Rpc;

namespace sembastandalone.Controllers;

public class NewsController : Controller {
    [Route("/news/list")]
    public async Task<IActionResult> News_List() {
        var req = await RequestSerializer.Deserialize<NewsListRequest>(Request);

        var res = NewsModel.News_List(req);

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }

    [Route("/news/user_list")]
    public IActionResult News_UserList() {
        var res = NewsModel.News_UserList();

        if (res == null) {
            return StatusCode(500);
        }

        return RequestSerializer.Serialize(res);
    }
}