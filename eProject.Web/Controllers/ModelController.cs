using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseMinton.Controllers
{
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult Rs6()
        {
            ViewBag.Title = "Audi RS6";

            return View();
        }

        public ActionResult Rs7()
        {
            ViewBag.Message = "Audi RS7";

            return View();
        }

        public ActionResult A8()
        {
            ViewBag.Message = "Audi A8";

            return View();
        }

        public ActionResult M5()
        {
            ViewBag.Message = "BMW M5";

            return View();
        }
        public ActionResult M8()
        {
            ViewBag.Message = "BMW M8";

            return View();
        }

        public ActionResult X5()
        {
            ViewBag.Message = "BMW X5";

            return View();
        }

        public ActionResult X7()
        {
            ViewBag.Message = "BMW X7";

            return View();
        }

        public ActionResult E63()
        {
            ViewBag.Message = "Mercedes-Benz E63";

            return View();
        }

        public ActionResult C63()
        {
            ViewBag.Message = "Mercedes-Benz C63";

            return View();
        }

        public ActionResult S63()
        {
            ViewBag.Message = "Mercedes-Benz S63";

            return View();
        }

        public ActionResult Stinger()
        {
            ViewBag.Message = "Kia Stinger";

            return View();
        }

        public ActionResult Giulia()
        {
            ViewBag.Message = "Alfa Romeo Giulia GTA";

            return View();
        }

    }
}