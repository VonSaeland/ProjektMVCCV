using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektMVCCV.Startup))]
namespace ProjektMVCCV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
