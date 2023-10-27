using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Mvc.Models;

namespace ECommerce.Mvc.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {
    }

    public IActionResult Index()
    {
        ViewBag.Risultato = "celo fatta";
        return View();
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
