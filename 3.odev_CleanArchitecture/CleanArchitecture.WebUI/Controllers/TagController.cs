using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class TagController : Controller
    {
        private readonly CA_BlogDbContext _context;
        public TagController(CA_BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult TagAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TagAdd(Tag tag)
        {
            await _context.Tags.AddAsync(tag);

            await _context.SaveChangesAsync();

            return RedirectToAction("Add", "Blog");
        }
    }
}
