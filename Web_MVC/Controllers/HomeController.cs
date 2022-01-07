using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_MVC.Models;

namespace Web_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*QuanLyNLDCEntities1 context = new QuanLyNLDCEntities1();

            var query = context.ThongTins
                   .GroupBy(p => p.ten)
                   .Select(g => new { name = g.Key, count = g.Select(w => w.hienTai) }).ToList();
            return Json(query, JsonRequestBehavior.AllowGet);*/
            return View();
        }

        public ActionResult GetData()
        {
            QuanLyNLDCEntities1 context = new QuanLyNLDCEntities1();

            var query = context.ThongTins
                    
                   .GroupBy(p => p.time)
                   .Select(g => new { time = g.Key.ToString(), value = g.Select(w => w.hienTai), name = g.Select(h=>h.ten.ToString())}).ToList();    
            return Json(query, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}