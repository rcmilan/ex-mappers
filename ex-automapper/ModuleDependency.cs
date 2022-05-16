using Microsoft.Extensions.DependencyInjection;

namespace ex_automapper
{
    public static class ModuleDependency
    {
        public static void AddAutomapperModule(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}