using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git.Startup))]
namespace Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
