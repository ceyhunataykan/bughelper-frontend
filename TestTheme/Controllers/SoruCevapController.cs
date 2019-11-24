using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestTheme.Controllers
{
    public class SoruCevapController : Controller
    {
        // GET: SoruCevap
        public ActionResult SoruYaz()
        {
            return View();
        }
    }
}