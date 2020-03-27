using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using KENDO.MVVM.Entities;
using KENDO.MVVM.Models;
using Microsoft.AspNetCore.Mvc;

namespace KENDO.MVVM.Controllers
{
    public class CategoryController : Controller
    {
        KendoMvvmDbContext _context;
        public CategoryController(KendoMvvmDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult CategoryList()
        {
            var categories = _context.Category.ToList();
            return Json(categories);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(int CategoryId, string CategoryName)
        {
            var category = new Category();
            category.CategoryName = CategoryName;
            _context.Category.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}