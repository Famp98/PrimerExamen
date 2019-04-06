using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimerParcialAbril.Startup))]
namespace PrimerParcialAbril
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
