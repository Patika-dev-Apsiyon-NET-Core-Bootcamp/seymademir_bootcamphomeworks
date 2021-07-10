using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSave_Demo.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Save()
        {
            return View();
        }

        public void Save(string bookName, string authorName)
        {
          
        }

        public IActionResult AddFavorite()
        {
            return View();
        }
    }
}
