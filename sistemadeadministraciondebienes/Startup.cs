using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sistemadeadministraciondebienes.Startup))]
namespace sistemadeadministraciondebienes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
