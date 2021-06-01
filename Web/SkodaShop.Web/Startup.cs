using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkodaShop.Web.Startup))]

namespace SkodaShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
