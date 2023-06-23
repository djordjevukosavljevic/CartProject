using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RVACart.Infrastructure;
using RVACart.Models;

namespace RVACart.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly DataContext _context;

        public ArticlesController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string categorySlug = "", int p = 1 )
        {
            int pageSize = 3;

            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.CategorySlug = categorySlug;

            if(categorySlug == "")
            {
                ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Articles.Count() / pageSize);

                return View(await _context.Articles.OrderByDescending(p => p.Id).Skip((p - 1) * pageSize).Take(pageSize).ToListAsync());
            
            }

            Category category = await _context.Categories.Where(c => c.Slug == categorySlug).FirstOrDefaultAsync(); 
            if(category == null) return RedirectToAction("Index");
           

            var articlesByCategory = _context.Articles.Where(p => p.CategoryId == category.Id);

            ViewBag.TotalPages = (int)Math.Ceiling((decimal)articlesByCategory.Count() / pageSize);

            return View(await articlesByCategory.OrderByDescending(p => p.Id).Skip((p - 1) * pageSize).Take(pageSize).ToListAsync());

        }
    }
}
