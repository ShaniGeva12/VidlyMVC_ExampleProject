using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMVC_ExampleProject.Startup))]
namespace VidlyMVC_ExampleProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
