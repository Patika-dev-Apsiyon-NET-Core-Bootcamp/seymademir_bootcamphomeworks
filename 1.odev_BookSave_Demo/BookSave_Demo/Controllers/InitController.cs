using BookSave_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSave_Demo.Controllers
{
    public class InitController : Controller
    {
        public IActionResult Index()
        {
            List<BookViewModel> books = new List<BookViewModel>();
            for (int i = 0; i < 5; i++)
            {
                BookViewModel bookViewModel = new BookViewModel();
                bookViewModel.BookName = $"A{i}";
                bookViewModel.BookName = $"B{i}";
                bookViewModel.PublishYear = 2018 + i; 

                books.Add(bookViewModel);

            }

            HttpContext.Session.Set<List<BookViewModel>>("books", books);
            return View();
        }
    }
}
