using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Employment.Infra.EntitiesConfiguration
{
    public static class ModelBuilderProvider
    {
        public static void AddModlBuilderConfigurations(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
