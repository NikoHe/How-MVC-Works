using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVPSoC.Startup))]
namespace MVPSoC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
