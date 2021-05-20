using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(categoryRepository.List(x => x.CategoryName == p));
            }
            return View(categoryRepository.TList());
        }

        [HttpGet] //Çakışma olmasın diye
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        //Category sınnıfına ait bir nesne göndericez bunun içinde yukarıda tanımladık
        public IActionResult CategoryAdd(Category p)
        {
            //Eğer geçemezse category de belirlediğim gerekli alanından sayfaya yönlendir
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CategoryGet(int id)
        {
            var x = categoryRepository.GetT(id);
            Category ct = new Category()
            {
                CategoryName=x.CategoryName,
                CategoryDescription=x.CategoryDescription,
                CategoryId=x.CategoryId
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            var x = categoryRepository.GetT(p.CategoryId);
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);

            return RedirectToAction("Index");
        }
        public IActionResult CategoryDelete(int id)
        {
            var x = categoryRepository.GetT(id);
            x.Status = false;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
      
    }
}
