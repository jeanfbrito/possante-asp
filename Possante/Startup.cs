using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Possante.Startup))]
namespace Possante
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
