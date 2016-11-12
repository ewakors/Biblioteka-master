using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteka.Controllers
{
    public class SignController : Controller
    {
        // GET: Sign
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sign_in()
        {
            return View();
        }
        public ActionResult Sign_up()
        {
            return View();
        }
    }
}