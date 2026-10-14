using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gdbk.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sistema con arquitectura por capas para Gdbk.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Roberto Alvarado Taborda.";

            return View();
        }
    }
}