using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LTWeb_buoi6.Startup))]
namespace LTWeb_buoi6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
