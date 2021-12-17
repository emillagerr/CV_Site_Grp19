using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVSite_Grupp19.Startup))]
namespace CVSite_Grupp19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
