using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace sembastandalone.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("")]
    public String Index()
    {
        return "index";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public String Error()
    {
        return "error";
    }
}
