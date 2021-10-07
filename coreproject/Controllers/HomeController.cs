using coreproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace coreproject.Controllers
{
    public class HomeController : Controller
    {
        NewContext db;


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, NewContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            var result = db.Categroys.ToList();
            return View(result);
        }

        public IActionResult Messages()
        {
            var result = db.contactU.ToList();
            return View(result);
        }
        public IActionResult TeamMemmbers()
        {
            var result = db.Teammemmbers.ToList();
            return View(result);
        }


        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var news = db.News.Find(id);
            db.Remove(news);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult News(int id)
        {
            Categroy c = db.Categroys.Find(id);
            ViewBag.cat = c.Name;
            var result = db.News.Where(x => x.CategroyId == id).OrderByDescending(y=>y.Date).ToList();
            return View(result);
        }
        public IActionResult SaveContact(ContactUs model)
        {
            if(ModelState.IsValid)
            {
                db.contactU.Add(model);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View("Contact",model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
