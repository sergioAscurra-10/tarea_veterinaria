using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tarea3_veterinaria.Models;

namespace tarea3_veterinaria.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult VerProductos()
    {
        return View();
    }

    public IActionResult AgregarCarrito()
    {
        TempData["mensaje2"] = "Felicidades tu producto se ha agregado correctamente";
        return RedirectToAction("index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
