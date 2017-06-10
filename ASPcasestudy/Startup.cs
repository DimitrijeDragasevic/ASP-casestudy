using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPcasestudy.Startup))]
namespace ASPcasestudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
