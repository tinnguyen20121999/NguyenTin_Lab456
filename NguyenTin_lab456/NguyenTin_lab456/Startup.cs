using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTin_lab456.Startup))]
namespace NguyenTin_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
