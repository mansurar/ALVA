using Microsoft.AspNetCore.Mvc;
using ALVA.Data;
using ALVA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace ALVA.Controllers
{
    public class HomeController(ApplicationDbContext context) : Controller
    {
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var products = await context.Products.ToListAsync();
            return View(products);
        }
    }
}