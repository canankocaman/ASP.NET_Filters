using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filtreleme.Startup))]
namespace Filtreleme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
