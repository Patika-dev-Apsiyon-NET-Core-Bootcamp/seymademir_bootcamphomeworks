using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CA_BlogDbContext _context;
        public CategoryController(CA_BlogDbContext context)
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

            return RedirectToAction("Add", "Blog");
        }
    }
}
