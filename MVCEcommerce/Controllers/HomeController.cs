using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCEcommerce.Context;
using MVCEcommerce.Models;
using System.Diagnostics;

namespace MVCEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NuevoYLiberadoDatabaseContext _context;

        public HomeController(ILogger<HomeController> logger, NuevoYLiberadoDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Productos != null ?
                          View(await _context.Productos.ToListAsync()) :
                          Problem("Entity set 'NuevoYLiberadoDatabaseContext.Productos'  is null.");
        }

        public async Task<IActionResult> Carrito()
        {
            return _context.Productos != null ?
                          View(await _context.Productos.ToListAsync()) :
                          Problem("Entity set 'NuevoYLiberadoDatabaseContext.Productos'  is null.");
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
}