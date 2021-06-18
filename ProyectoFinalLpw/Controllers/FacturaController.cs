using ProyectoFinalLpw.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalLpw.Controllers
{
    public class FacturaController : Controller
    {

        private VentasEntities1 db = new VentasEntities1();

        // GET: Factura


        public ActionResult Index()
        {
            var facturas = db.Facturas.ToList();
            return View(facturas);
        }
        public ActionResult Create()

        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Facturas facturas)
        {
            db.Facturas.Add(facturas);
            db.SaveChanges();
            return View();
        }

        public ActionResult Edit(int? id)
        {
            Facturas facturas = db.Facturas.Find(id);
            return PartialView("_Edit", facturas);
        }
        [HttpPost]
        public ActionResult Edit(Facturas facturas)
        {
            db.Entry(facturas).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                var facturas = db.Facturas.Find(id);
                return PartialView("_Delete", facturas);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var facturas = db.Facturas.Find(id);
            db.Facturas.Remove(facturas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

   