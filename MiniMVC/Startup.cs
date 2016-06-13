using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiniMVC.Startup))]
namespace MiniMVC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
