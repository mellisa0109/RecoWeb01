using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecoWeb01.Startup))]
namespace RecoWeb01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
