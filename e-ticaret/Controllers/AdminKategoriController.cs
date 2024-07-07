using BusinessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_ticaret.Controllers
{
    public class AdminKategoriController : Controller
    {
        // GET: AdminKategori
        CategoryRepository CategoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(CategoryRepository.List());
        }


        public ActionResult Create() 
        {
            return View();
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Create(Category p)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.Insert(p);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Bir hata oluştu");
            return View();

        }

        public ActionResult Delete(int id)
        {
            var delete = CategoryRepository.GetById(id);
            CategoryRepository.Delete(delete);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id) 
        {
            var update = CategoryRepository.GetById(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Category p)
        {
            if (ModelState.IsValid) 
            {
                var update = CategoryRepository.GetById(p.Id);
                update.Name = p.Name;
                update.Description = p.Description;
                CategoryRepository.Update(update);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Bir hata oluştu");
            return View();
        }
    }
}