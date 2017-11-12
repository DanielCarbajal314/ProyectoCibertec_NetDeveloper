using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Peticiones;
using InterfacesInventario.Productos.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AplicacionWeb.Controllers.API
{
    public class ProductosController : ApiController
    {

        private IGestorDeProductos _gestorDeProductos = new GestorDeProductos();
        // GET: api/Productos
        public List<ProductoRegistrado> Get()
        {
            return _gestorDeProductos.ListarTodosLosProductos();
        }


        // POST: api/Productos
        public void Post(NuevoProducto nuevoProducto)
        {
            _gestorDeProductos.CrearProducto(nuevoProducto);
        }
    }
}
