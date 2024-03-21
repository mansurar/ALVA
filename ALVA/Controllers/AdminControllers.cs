using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ALVA.Data;
using ALVA.Models;
using Microsoft.EntityFrameworkCore;

namespace ALVA.Controllers
{
    [Authorize(Roles = "Admin")] // Убедитесь, что доступ к контроллеру имеют только администраторы
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        
    }
}