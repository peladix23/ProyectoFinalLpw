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
    public class ProcuctosController : Controller
    {

        private VentasEntities1 db = new VentasEntities1();

        // GET: Factura


        public ActionResult Index()
        {
            var productos = db.Productos.ToList();
            return View(productos);
        }
        public ActionResult Create()

        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Productos productos)
        {
            db.Productos.Add(productos);
            db.SaveChanges();
            return View();
        }

        public ActionResult Edit(int? id)
        {
            Productos productos= db.Productos.Find(id);
            return PartialView("_Edit", productos);
        }
        [HttpPost]
        public ActionResult Edit(Productos productos)
        {
            db.Entry(productos).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                var productos = db.Facturas.Find(id);
                return PartialView("_Delete", productos);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var productos = db.Productos.Find(id);
            db.Productos.Remove(productos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

