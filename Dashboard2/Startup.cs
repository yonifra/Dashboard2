using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dashboard2.Startup))]
namespace Dashboard2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
