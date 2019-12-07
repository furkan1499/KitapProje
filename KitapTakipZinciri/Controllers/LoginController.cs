using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapTakipZinciri.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitapTakipZinciri.Controllers
{
    public class LoginController : Controller
    {

        MyDB db = new MyDB();


        [HttpPost]
        public IActionResult Index(string username,string password)
        {
            var admin = db.admins.Where(x => x.userName == username & x.password == password).ToList();
            if (admin.Count ==1)
            {
                
                return Redirect("/books");
            }
            else
            {
                return Redirect("/");
            }
        }
    }
}