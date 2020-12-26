using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TruckPlanWebApp.DAL;
 

namespace TruckPlanWebApp.Controllers
{
    public class HomeController : Controller
    {
        private TruckPlanContext db = new TruckPlanContext();

        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}