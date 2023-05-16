using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace portfolio_new.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly MyDbContext _context;

        public PortfolioController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }
    }
}
