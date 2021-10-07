using coreproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreproject.Areas.AdminArea.Controllers
{
    [Area("AdminPanel")]
    
    public class DefaultController : Controller
    {
        
        NewContext db;
        public DefaultController(NewContext context)
        {
            db = context;
                }
        public IActionResult Index()
        {
            int teamcount = db.Teammemmbers.Count();
            int Newscount = db.News.Count();
            int contactcount = db.contactU.Count();
            int categorycount = db.Categroys.Count();
            return View(
                new AdminNumbers
                {
                    team=teamcount,
                    news = Newscount,
                    categorys = categorycount,
                    contact = contactcount
                });
        }
    }

    public class AdminNumbers { 
        public int team { get; set; }
        public int contact { get; set; }
        public int news { get; set; }
        public int categorys { get; set; }
    }
}
