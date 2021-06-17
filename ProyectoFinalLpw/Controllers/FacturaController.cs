using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalLpw.Controllers
{
    public class FacturaController : Controller
    {
        private VentasdbEntities db = VentasdbEnt
        // GET: Factura
        public ActionResult Factura()
        {
            return View();
        }
    }
}