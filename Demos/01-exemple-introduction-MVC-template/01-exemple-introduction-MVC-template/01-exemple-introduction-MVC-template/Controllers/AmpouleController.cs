using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_exemple_introduction_MVC_template.Controllers
{
    public class AmpouleController : Controller
    {
        // GET: Ampoule
        public ActionResult Etat(string id)
        {
            ViewBag.etat = id;
            return View();
        }
    }
}