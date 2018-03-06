using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vat_compliance.Startup))]
namespace vat_compliance
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      ConfigureAuth(app);
    }
  }
}
