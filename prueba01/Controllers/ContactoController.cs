using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using prueba01.Models;

namespace prueba01.Controllers;

public class ContactoController : Controller
{
    private readonly ILogger<ContactoController> _logger;

    public ContactoController(ILogger<ContactoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index2()
    {
        return View();
    }

}
