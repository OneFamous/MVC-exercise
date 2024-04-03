using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(exercise.Startup))]
namespace exercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
