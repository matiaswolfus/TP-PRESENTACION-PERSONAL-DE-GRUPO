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
            HttpContext.Session.SetString("idUser", idUsuario.ToString());
            return View ("mostrarUsuario");
        }
    }
    public IActionResult getDatoF()
    {
    if (HttpContext.Session.GetString("idUser")== null) 
    {
        return RedirectToAction("Index");
    }
    int idusuario = int.Parse(HttpContext.Session.GetString("idUser"));
    ViewBag.listaFamiliar = BD.GetDatoFamiliar(idusuario);
    return View("datoFamiliar");
    }

    public IActionResult getDatoI()
    {
    if (HttpContext.Session.GetString("idUser")== null) 
    {
        return RedirectToAction("Index");
    }
    int idUsuario = int.Parse(HttpContext.Session.GetString("idUser"));
    ViewBag.listaInteres = BD.GetDatoInteres(idUsuario);
    return View("datoInteres");
    }
    public IActionResult logueo ()
    {
        return View ("logueo");
    }
        public IActionResult logOut()
    {
        HttpContext.Session.Remove("idUser");
        return RedirectToAction("Index");
    }
    public IActionResult volver()
    {
        return View("mostrarUsuario");
    }
}
