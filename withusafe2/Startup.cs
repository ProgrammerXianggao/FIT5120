using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(withusafe2.Startup))]
namespace withusafe2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
