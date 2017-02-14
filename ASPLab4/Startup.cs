using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPLab4.Startup))]
namespace ASPLab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
