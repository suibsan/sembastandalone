using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using sembastandalone.Utils;

namespace sembastandalone.Controllers;

public class SembaController : Controller
{
    private ISembaWrapper sembaWrapper;

    public SembaController(ISembaWrapper wrapper) {
        sembaWrapper = wrapper;
    }

    [Route("/semba/{name}")]
    public async Task<String> SembaPrivate(string name) {
        var reqBytes = await RequestSerializer.GetBodyAsync(Request);
        var reqStr = System.Text.Encoding.UTF8.GetString(reqBytes);
        var res = sembaWrapper.Call($"/semba/{name}", reqStr);
        return res != null ? res : "";
    }
}
