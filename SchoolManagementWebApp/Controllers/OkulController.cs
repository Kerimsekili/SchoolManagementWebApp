using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagementWebApp.Controllers;
using SchoolManagementWebApp.Models;

namespace SchoolManagementWebApp.Controllers
{
    public class OkulController : Controller
    {
        // GET: School
        TaskDbEntities db = new TaskDbEntities();
        public ActionResult Index()
        {
            var ogrenciler = db.Ogrencis.ToList();
            return View(ogrenciler);
        }

        [HttpGet]
        public ActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OgrenciEkle(Ogrenci t)
        {
            db.Ogrencis.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgrenciSil(int id)
        {
            var ogrenci = db.Ogrencis.Find(id);
            db.Ogrencis.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgrenciGetir(int id)
        {
            var ogrenci = db.Ogrencis.Find(id);
            return View("OgrenciGetir", ogrenci);
        }

        public ActionResult OgrenciGuncelle(Ogrenci t)
        {
            var ogrenci = db.Ogrencis.Find(t.Id);
            ogrenci.AdSoyad = t.AdSoyad;
            ogrenci.KayitTarih = t.KayitTarih;
            ogrenci.OgrenciNo = t.OgrenciNo;
            ogrenci.DTarih = t.DTarih;
            ogrenci.Bolum = t.Bolum;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}