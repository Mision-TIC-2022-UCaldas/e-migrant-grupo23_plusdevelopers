using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMIGRANT.Startup))]
namespace EMIGRANT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
