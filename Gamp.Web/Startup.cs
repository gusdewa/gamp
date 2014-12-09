using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gamp.Startup))]
namespace Gamp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
