using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

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

        [HttpPost]
      public IActionResult logIn(string mail, string contraseña)
    {
        int idUsuario = -1;
        idUsuario = BD.logIn(mail, contraseña);
        if (idUsuario == -1) 
        {
            return View("logueoFallido");
        } else 
        {
            Usuario usuario = BD.GetUsuario(idUsuario);
            HttpContext.Session.SetString("logueo", objeto.ObjetoATexto(usuario));
            return View ("mostrarUsuario");
        }
    }
    public IActionResult getDatoF(int idUsuario)
    {
        ViewBag.listaDatoFamiliar = new List<datoFamiliar>();
        ViewBag.listaDatoFamiliar = BD.GetDatoFamiliar(idUsuario);
        return View ("datoFamiliar");
    
    }

    public IActionResult getDatoI(int idUsuario)
    {
        ViewBag.listaInteres = new List<datoInteres>();
        ViewBag.listaInteres = BD.GetDatoInteres(idUsuario);
        return View ("datoInteres");
    }
    public IActionResult logueo ()
    {
        return View ("logueo");
    }
}
