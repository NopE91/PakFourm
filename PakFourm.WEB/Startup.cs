using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PakFourm.WEB.Startup))]
namespace PakFourm.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
