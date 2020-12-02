using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPFINAL.Startup))]
namespace TPFINAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
