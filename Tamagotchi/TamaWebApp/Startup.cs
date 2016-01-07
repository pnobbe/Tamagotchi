using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TamaWebApp.Startup))]
namespace TamaWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
