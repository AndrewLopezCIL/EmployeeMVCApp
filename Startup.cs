using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeMVCApp.Startup))]
namespace EmployeeMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
