using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTheme.Models;

namespace TestTheme.Controllers
{
    public class ProfilController : Controller
    {
        // GET: Profil
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FotoGuncelle()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult FotoGuncelle(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    var _FileName = Path.GetFileName(file.FileName);
                    var _path = Path.Combine(Server.MapPath("~/UploadFiles"), _FileName);
                    file.SaveAs(_path);
                }

                ViewBag.Message = "<div class=\"alert alert-success\" role=\"alert\">Güncelleme Başarılı</div>";
                return View();
            }
            catch
            {
                ViewBag.Message = "<div class=\"alert alert-warning\" role=\"alert\">Hata Oluştu. Tekrar Deneyiniz.</div>";
                return View();
            }
        }
        public ActionResult ProfilDuzenle()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EpostaDegistir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EpostaDegistir(EmailVal model)
        {
            if (model.NewEmail == model.ConfirmEmail)
            {
                ViewBag.Message = "<div class=\"alert alert-success\" role=\"alert\">Güncelleme Başarılı</div>";
                return View();
            }
            ViewBag.Message = "<div class=\"alert alert-warning\" role=\"alert\">Hata Oluştu. Tekrar Deneyiniz.</div>";
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