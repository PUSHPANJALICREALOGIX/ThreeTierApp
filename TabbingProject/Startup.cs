using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TabbingProject.Startup))]
namespace TabbingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
