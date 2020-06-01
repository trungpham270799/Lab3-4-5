using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_4_5.Startup))]
namespace Lab3_4_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
