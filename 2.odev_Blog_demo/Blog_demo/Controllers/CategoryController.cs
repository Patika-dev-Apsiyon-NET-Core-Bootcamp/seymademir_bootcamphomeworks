using Blog_demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_demo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ArticleContext _context;
        public CategoryController(ArticleContext context)
        {
            _context = context;
        }

        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAdd(Category category)
        {
            await _context.Categories.AddAsync(category);

            await _context.SaveChangesAsync();

            return RedirectToAction("Add", "Article");
        }
    }
}
