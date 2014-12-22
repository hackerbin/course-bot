using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(course_bot.Startup))]
namespace course_bot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
