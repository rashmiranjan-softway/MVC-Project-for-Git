using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Project_for_Git.Startup))]
namespace MVC_Project_for_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
