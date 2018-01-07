using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Respuestas;
using InterfacesInventario.Productos.Peticiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaEnWebForms.Tienda
{
    public partial class Productos : System.Web.UI.Page
    {

        IGestorDeProductos _gestorDeProductos = new GestorDeProductos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<ProductoRegistrado> ListarProductos() {
            return this._gestorDeProductos.ListarTodosLosProductos();
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevoProducto = new NuevoProducto();
            nuevoProducto.Precio = int.Parse(this.Precio.Text);
            nuevoProducto.Nombre = this.Nombre.Text;
            this._gestorDeProductos.CrearProducto(nuevoProducto);
            ActualizarFormulario();
        }

        private void ActualizarFormulario() {
            this.Precio.Text = "";
            this.Nombre.Text = "";
            this.ListaDeProductos.DataBind();
        }

    }
}