using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvcilMaket.Controllers
{
    public class TrController : Controller
    {
        // GET: Tr
        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Urunler()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}