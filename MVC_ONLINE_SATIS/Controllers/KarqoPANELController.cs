﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ONLINE_SATIS.Models.Sinifler;
namespace MVC_ONLINE_SATIS.Controllers
{
    public class KarqoPANELController : Controller
    {
        // GET: KarqoPANEL
        Context db = new Context();
        public ActionResult Index()
        {
            var m = (string)Session["Mail"];
            var ad = (string)Session["KarqoIsciAD"];
            var soyad = (string)Session["KarqoIsciSoyad"];

            var deyerler = db.KarqoISCILERIs.FirstOrDefault(x => x.Mail == m);
            ViewBag.email = m;
            ViewBag.musteri = ad;
            ViewBag.musteri1 = soyad;
            return View(deyerler);
        }
    }
}