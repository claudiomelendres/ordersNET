using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrdersWeb.Startup))]
namespace OrdersWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
