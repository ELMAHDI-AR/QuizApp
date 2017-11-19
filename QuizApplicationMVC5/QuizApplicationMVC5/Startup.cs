using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizApplicationMVC5.Startup))]
namespace QuizApplicationMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
