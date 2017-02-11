using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMECommerce.Web.Startup))]
namespace DMECommerce.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
