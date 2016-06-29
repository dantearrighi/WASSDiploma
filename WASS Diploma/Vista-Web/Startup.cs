using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vista_Web.Startup))]
namespace Vista_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
