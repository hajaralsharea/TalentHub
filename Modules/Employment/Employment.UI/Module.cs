using Employment.Domain;

namespace Employment.UI
{
  public class Module : IModule
  {
    public void AddServices(IServiceCollection services, IConfiguration config)
    {
      services.AddServices();
    }
  }
}
