using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cSharp_WebApp.Startup))]
namespace cSharp_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
