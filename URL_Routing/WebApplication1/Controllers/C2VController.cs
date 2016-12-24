using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class C2VController : Controller
    {
        // GET: C2V
        public ActionResult Index()
        {
            ViewData["mydate"] = DateTime.Now.ToString();
            ViewData["slno"] = "123";
            return View();
        }
    }
}