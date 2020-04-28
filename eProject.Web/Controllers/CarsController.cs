using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Companies()
        {
            ViewBag.Message = "Companies";

            return View();
        }

        public ActionResult Audi()
        {
            ViewBag.Message = "Audi";

            return View();
        }

        public ActionResult BMW()
        {
            ViewBag.Message = "BMW";

            return View();
        }

        public ActionResult Benz()
        {
            ViewBag.Message = "Benz";

            return View();
        }

        public ActionResult Kia()
        {
            ViewBag.Message = "Kia";

            return View();
        }

        public ActionResult AlfaRomeo()
        {
            ViewBag.Message = "Alfa Romeo";

            return View();
        }
    }
}