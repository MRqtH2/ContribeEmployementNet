using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BokAffar.Startup))]
namespace BokAffar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
