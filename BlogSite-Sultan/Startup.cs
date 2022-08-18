using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogSite_Sultan.Startup))]
namespace BlogSite_Sultan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
