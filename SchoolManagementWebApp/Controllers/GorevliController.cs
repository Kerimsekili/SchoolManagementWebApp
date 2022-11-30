using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagementWebApp.Models;
using SchoolManagementWebApp.Controllers;

namespace SchoolManagementWebApp.Controllers
{
    public class GorevliController : Controller
    {
        // GET: Gorevli
        TaskDbEntities db = new TaskDbEntities();
        public ActionResult Index()
        {
            var gorevli = db.OkulYonetims.ToList();
            return View(gorevli);
        }

        [HttpGet]
        public ActionResult GorevliEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GorevliEkle(OkulYonetim t)
        {
            db.OkulYonetims.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GorevliSil(int id)
        {
            var gorevli = db.OkulYonetims.Find(id);
            db.OkulYonetims.Remove(gorevli);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GorevliGetir(int id)
        {
            var gorevli = db.OkulYonetims.Find(id);
            return View("GorevliGetir", gorevli);
        }

        public ActionResult GorevliGuncelle(OkulYonetim t)
        {
            var gorevli = db.OkulYonetims.Find(t.Id);
            gorevli.AdSoyad = t.AdSoyad;
            gorevli.Gorevi = t.Gorevi;
            gorevli.YonetimTip = t.YonetimTip;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}