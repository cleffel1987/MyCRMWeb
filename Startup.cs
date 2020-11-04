using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCRMWeb.Startup))]
namespace MyCRMWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
