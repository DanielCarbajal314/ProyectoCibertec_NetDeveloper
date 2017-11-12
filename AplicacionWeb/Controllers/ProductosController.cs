using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWeb.Controllers
{
    public class ProductosController : Controller
    {
        private IGestorDeProductos _gestorDeProductos = new GestorDeProductos();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult TablaDeProductos(string type)
        {
            List<ProductoRegistrado> listaDeProductos = _gestorDeProductos.ListarTodosLosProductos();
            return PartialView(listaDeProductos);
        }        
    }
}
