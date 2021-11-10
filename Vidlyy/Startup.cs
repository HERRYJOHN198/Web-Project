using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlyy.Startup))]
namespace Vidlyy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
