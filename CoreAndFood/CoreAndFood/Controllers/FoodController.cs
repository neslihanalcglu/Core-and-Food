using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context c = new Context();
        FoodRepository foodRepository = new FoodRepository();
        
        public IActionResult Index(int page=1) //Sayfalar arası dolaşabilmek için parametre gönderdim
        {
            return View(foodRepository.TList("Category").ToPagedList(page,3));
        }
        [HttpGet]
        public IActionResult FoodAdd()
        {
            
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult FoodAdd(urunekle p)
        {
            Food f = new Food();
            if (p.ImageURL != null)//resim kısmı boş değilse
            {
                var extension = Path.GetExtension(p.ImageURL.FileName);
                var newimagename = Guid.NewGuid() + extension;//benzersiz değer + uzantıdan gelen değer
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/resimler/",newimagename);//seçtiğim dosya yolunu alacak
                var stream = new FileStream(location, FileMode.Create);//ilgili lokasyona dosyayı oluşturmak için hazırla
                p.ImageURL.CopyTo(stream);//gönderilen rsmin değerini kopyala
                f.ImageURL = newimagename;
            }
            f.Name = p.Name;
            f.Price = p.Price;
            f.Stock = p.Stock;
            f.CategoryId = p.CategoryId;


            foodRepository.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int id)
        {
            foodRepository.TDelete(new Food { FoodId=id });
            return RedirectToAction("Index");
        }
        
        public IActionResult FoodGet(int id)
        {
            var x = foodRepository.GetT(id);
            List<SelectListItem> values = (from a in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = a.CategoryName,
                                               Value = a.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
  
            
            Food f = new Food()
            {
                FoodId=x.FoodId,
                CategoryId=x.CategoryId,
                Name=x.Name,
                Price=x.Price,
                Stock=x.Stock,
                ImageURL = x.ImageURL,
                Description =x.Description,
                
            };
            return View(f);
        }
        [HttpPost]
        public IActionResult FoodUpdate(Food p)
        {
            var x = foodRepository.GetT(p.FoodId);
            x.Name = p.Name;
            x.Price = p.Price;
            x.Stock = p.Stock;
            x.ImageURL = p.ImageURL;
            x.Description = p.Description;
            x.CategoryId = p.CategoryId;
            foodRepository.TUpdate(x);

            return RedirectToAction("Index");
        }

    }
}
