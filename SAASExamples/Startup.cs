using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAASExamples.Startup))]
namespace SAASExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
