using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestTheme.Controllers
{
    public class ProfilController : Controller
    {
        // GET: Profil
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FotoGuncelle()
        {
            return View();
        }
        public ActionResult ProfilDuzenle()
        {
            return View();
        }
        public ActionResult EpostaDegistir()
        {
            return View();
        }
        public ActionResult ParolaDegistir()
        {
            return View();
        }
        public ActionResult TwoFactor()
        {
            return View();
        }
        public ActionResult UyelikIptal()
        {
            return View();
        }
    }
}