using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Strefa2._0.Startup))]
namespace Strefa2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
