using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDataFromControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FirstName = "John Ini";
            ViewBag.LastName = "Heritage";
            ViewBag.Address = "Epe, Lagos";
            return View();
        }
    }
}