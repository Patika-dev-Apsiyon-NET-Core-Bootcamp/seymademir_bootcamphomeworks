using Blog_demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_demo.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleContext _context = null;

        public ArticleController(ArticleContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Add()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View();
        }

        [HttpPost]
        public IActionResult Add(ArticleViewModel model)
        {
            return View();
        }

        public IActionResult ArticleAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ArticleAdd(Article article)
        {
            await _context.Articles.AddAsync(article);

            await _context.SaveChangesAsync();

            return RedirectToAction("Add", "Article");
        }
    }
}
