using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Orderly.WebMVC.Startup))]
namespace Orderly.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
