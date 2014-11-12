using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoreStandDesign.Startup))]
namespace CoreStandDesign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
