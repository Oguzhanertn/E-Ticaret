using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Context;
using PagedList;
using PagedList.Mvc;

namespace e_ticaret.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DataContext Db = new DataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Comment(int sayfa=1) 
        {
            return View(Db.Comments.ToList().ToPagedList(sayfa,15));
        }

        public ActionResult Delete(int id)
        {
            var delete = Db.Comments.Where(x => x.Id == id).FirstOrDefault();
            Db.Comments.Remove(delete);
            Db.SaveChanges();
            return RedirectToAction("Comment");
        }
    }
}