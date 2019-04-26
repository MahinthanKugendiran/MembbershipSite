using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Membershipss.Startup))]
namespace Membershipss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
