using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MassarSystem.Startup))]
namespace MassarSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
