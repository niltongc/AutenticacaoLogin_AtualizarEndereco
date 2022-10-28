using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProAuto.Models;
using ProAuto.Context;

namespace ProAuto.Controllers;

public class HomeController : Controller
{
    private readonly AssociadoContext _context;
    // public HomeController(AssociadoContext context)
    // {
    //     _context = context;
    // }
    
    public IActionResult Index()
    {
        // var associados = _context.Associados.ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

   
}
