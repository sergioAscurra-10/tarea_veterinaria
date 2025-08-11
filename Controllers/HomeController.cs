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

    [HttpGet]
    public IActionResult RegistroMascota()
    {
        return View(new Mascota());
    }

    [HttpPost]
    public IActionResult RegistroMascota(Mascota mascota)
    {
        if (ModelState.IsValid)
        {
            TempData["Mensaje"] = "La mascota '"+ mascota.nombre + "' ha sido registrada con exito!!";

            return RedirectToAction("Index"); ;
        }

        return View(mascota);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
