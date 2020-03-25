using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Capa_InterfazUsuario.Startup))]
namespace Capa_InterfazUsuario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
