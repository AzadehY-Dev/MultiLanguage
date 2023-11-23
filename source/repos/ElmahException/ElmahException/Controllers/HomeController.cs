using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElmahException.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id = "123")
        {
            int num = Convert.ToInt32(id);
            return View();
        }
    }
}