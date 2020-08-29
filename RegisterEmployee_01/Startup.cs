using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegisterEmployee_01.Startup))]
namespace RegisterEmployee_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
