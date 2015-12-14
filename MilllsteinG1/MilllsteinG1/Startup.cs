using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MilllsteinG1.Startup))]
namespace MilllsteinG1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
