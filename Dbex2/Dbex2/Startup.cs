using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dbex2.Startup))]
namespace Dbex2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
