using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auth_MVC.Startup))]
namespace Auth_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
