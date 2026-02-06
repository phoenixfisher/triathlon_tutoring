using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using triathlon_tutoring.Models;

namespace triathlon_tutoring.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult LearningSuite()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    // Render TutorCalculator view
    public IActionResult TutorCalculator()
    {
        ViewData["HourlyRate"] = 50;
        return View();
    }
}