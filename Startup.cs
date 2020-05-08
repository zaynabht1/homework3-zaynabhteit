using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(homework3_zaynabhteit.Startup))]
namespace homework3_zaynabhteit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
