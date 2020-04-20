using LPPA.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPPA.WebSite.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            //
            var producto = new Producto();

            producto.Codigo = Convert.ToInt32(form["codigo"]);
            producto.Nombre = form["nombre"];
            producto.Descripcion = form["descripcion"];

            Dominio.Add(producto);

            return RedirectToAction("Index");
        }
    }
}