using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(distribution_mvc.Startup))]
namespace distribution_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
