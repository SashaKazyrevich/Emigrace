using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emigrace.Startup))]
namespace Emigrace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
