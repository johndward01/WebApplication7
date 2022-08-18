using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WebApplication7.Models;
using WebApplication7.Models.Aviation;

namespace WebApplication7.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var client = new HttpClient();
        var url = "https://airlabs.co/api/v9/airlines?&api_key=d6be5dd7-cf0b-44f6-a883-3d1b8a475ae2";
        var response = client.GetStringAsync(url).Result;
        var root = JsonConvert.DeserializeObject<Root>(response);
        return View(root);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
