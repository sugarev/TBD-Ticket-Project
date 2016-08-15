using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TBD_Ticket_Project.Startup))]
namespace TBD_Ticket_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
