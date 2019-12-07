using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapTakipZinciri.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitapTakipZinciri.Controllers
{
    public class SearchController : Controller
    {
        MyDB db = new MyDB();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string isbn)
        {
            var query = db.books.Where(x => x.ISBN == isbn).FirstOrDefault();
            return View(query);
        }
    }
}