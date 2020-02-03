using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CtrlWebPPT.Startup))]
namespace CtrlWebPPT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
