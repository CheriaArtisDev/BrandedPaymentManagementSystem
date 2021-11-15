using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BPManagementSystem.Startup))]
namespace BPManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
