using Beryllium_ASP.Net.DAL;
using Beryllium_ASP.Net.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium_ASP.Net.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                WorkBlogs = _context.WorkBlogs.ToList(),
                Slider=_context.Slider.ToList(),
                News=_context.News.ToList(),
                Testimonials=_context.Testimonials.ToList()
            };

            return View(home);
        }

    }
}
