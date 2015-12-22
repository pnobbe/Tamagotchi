using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TamaDemo.Startup))]
namespace TamaDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
