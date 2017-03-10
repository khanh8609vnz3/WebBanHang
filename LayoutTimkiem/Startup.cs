using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LayoutTimkiem.Startup))]
namespace LayoutTimkiem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
