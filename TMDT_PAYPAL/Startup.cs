using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_PAYPAL.Startup))]
namespace TMDT_PAYPAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
