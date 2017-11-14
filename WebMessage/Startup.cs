using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMessage.Startup))]
namespace WebMessage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
