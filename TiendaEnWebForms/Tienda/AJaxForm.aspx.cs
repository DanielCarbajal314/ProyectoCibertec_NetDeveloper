using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaEnWebForms.Tienda
{
    public partial class AJaxForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.HoraDeCarga.Text = DateTime.Now.ToShortTimeString();
        }

        protected void DimeLaHora_Click(object sender, EventArgs e)
        {
            this.Hora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}