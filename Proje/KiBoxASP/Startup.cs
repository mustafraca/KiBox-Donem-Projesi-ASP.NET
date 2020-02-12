using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiBoxASP.Startup))]
namespace KiBoxASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
