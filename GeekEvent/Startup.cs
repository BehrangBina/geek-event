using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeekEvent.Startup))]
namespace GeekEvent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
