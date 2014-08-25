using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftITMvc.Startup))]
namespace SoftITMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
