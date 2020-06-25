using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(secondapp.Startup))]
namespace secondapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
