using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Model14_01.Startup))]
namespace Model14_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
