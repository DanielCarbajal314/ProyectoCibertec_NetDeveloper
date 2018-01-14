using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Peticiones;
using InterfacesInventario.Productos.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaEnWebForms.Tienda
{
    public partial class MantenimientoDeProductosConMasterPage : System.Web.UI.Page
    {
        IGestorDeProductos _gestorDeProductos = new GestorDeProductos();
        protected void Page_Load(object sender, EventArgs e)
        {
            MakeGridViewPrinterFriendly(this.ListaDeProductos);
        }

        public List<ProductoRegistrado> ListarProductos()
        {
            return this._gestorDeProductos.ListarTodosLosProductos();
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevoProducto = new NuevoProducto();
            nuevoProducto.Precio = int.Parse(this.Precio.Text);
            nuevoProducto.Nombre = this.Nombre.Text;
            var productoRegistrado = this._gestorDeProductos.CrearProducto(nuevoProducto);
            ActualizarFormulario();
            MakeGridViewPrinterFriendly(this.ListaDeProductos);

            EnviarMensajeAlMasterPage("Se registro con exito el producto "+nuevoProducto.Nombre+" con Id : "+ productoRegistrado.Id);

        }

        private void EnviarMensajeAlMasterPage(string mensaje) {
            var master = Master as SiteMaster;
            master.CambiarMensaje(mensaje);
        }

        private void ActualizarFormulario()
        {
            this.Precio.Text = "";
            this.Nombre.Text = "";
            this.ListaDeProductos.DataBind();
            ClientScript.RegisterStartupScript(
                                this.GetType(), 
                                "Notificacion", 
                                "alert('" + "Se guardo con exito el producto" + "');",
                                true);
        }

        private void MakeGridViewPrinterFriendly(GridView gridView)
        {
            if (gridView.Rows.Count > 0)
            {
                gridView.UseAccessibleHeader = true;
                gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}