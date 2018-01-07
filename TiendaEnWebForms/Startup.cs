using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaEnWebForms.Startup))]
namespace TiendaEnWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
