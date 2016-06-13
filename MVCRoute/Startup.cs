using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRoute.Startup))]
namespace MVCRoute
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
