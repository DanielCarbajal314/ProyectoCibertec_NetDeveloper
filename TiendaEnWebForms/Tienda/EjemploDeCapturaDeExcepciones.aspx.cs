using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaEnWebForms.Tienda
{
    public partial class EjemploDeCapturaDeExcepciones : System.Web.UI.Page
    {
        private static readonly ILog log =
            LogManager.GetLogger(typeof(EjemploDeCapturaDeExcepciones));
        protected void Page_Load(object sender, EventArgs e)
        {
            throw new Exception("Este es un error al iniciar la pagina");
        }

        void Page_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            log.Error(exc.Message,exc);
            Server.ClearError();
        }
    }
}