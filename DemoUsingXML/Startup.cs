using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoUsingXML.Startup))]
namespace DemoUsingXML
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
