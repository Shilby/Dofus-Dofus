using Dofus.Services;
using Dofus.Services.Interfaces;

namespace Dofus.DI
{
    public static class ServiceInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<INewsServices, NewsServices>();
        }
    }
}
