using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using simplesecureweb.Models;

namespace simplesecureweb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult About() {
        ViewData["Message"]= "Your application description gape.";
        return View();
    } 

    public IActionResult Privacy()
    {
        ViewBag.username ="EsraDuwiSaputra";
        string[] fruits = new string [] {"Apple","Banana","Orange"};
        ViewBag.fruits=fruits;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
