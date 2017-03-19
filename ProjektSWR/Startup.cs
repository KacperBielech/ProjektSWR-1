using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektSWR.Startup))]
namespace ProjektSWR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
