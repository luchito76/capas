using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Capas.Startup))]
namespace Capas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
