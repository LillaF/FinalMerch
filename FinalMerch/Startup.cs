using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalMerch.Startup))]
namespace FinalMerch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
