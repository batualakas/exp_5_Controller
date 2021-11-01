using exp_5_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace exp_5_Controller.Controllers
{
    public class HomeController : Controller
    {
        /*
        -ActionResult 
        -ContentResult
         
         
         */
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult Hakkimizda()
        {
            var str = "<h1>Hoşgeldiniz, burası hakkımızda sayfası!<h1>";
            return Content(str);
        }
        public FileResult Indir()
        {
            // content type'lara  mime types'daş erişilebilir
            return new FilePathResult(@"C:\Users\batua\Desktop\IndirilecekDosya.pdf", "application/pdf");
        }
        // sayfaya yenileme süresi vermek için kullanılır. istekleri yaparsınız ama bu süre boyunca sonuç vermez
        [OutputCache(Duration =60)]
        public JsonResult OgrenciListesiniGetir()
        {
            var ogrenciler = new List<Student>()
            {
                new Student(){Id=1, Ad="batu",Soyad="Alakaş"},
                new Student(){Id=2, Ad="Orkun",Soyad="İnce"},
                new Student(){Id=3, Ad="Eray",Soyad="Ergin"}
            };
            //json : javascript object notation.
            /*
             
             */
            return Json(ogrenciler, JsonRequestBehavior.AllowGet);

        }
    }
}