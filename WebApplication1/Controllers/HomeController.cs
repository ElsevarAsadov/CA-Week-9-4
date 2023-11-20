using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ModelViews.Home;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [ActivatorUtilitiesConstructor]
    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        HomeIndexMV viewData = new()
        {
                Heros = _context.Hero.ToList<Hero>(),
                Cards = _context.Card.ToList<Card>(),
        };
        return View(viewData);
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