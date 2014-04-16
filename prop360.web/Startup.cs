using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prop360.web.Startup))]
namespace prop360.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
