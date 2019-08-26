using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(withU.Startup))]
namespace withU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
