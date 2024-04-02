using Dofus.Repository;
using Dofus.Repository.Interfaces;

namespace Dofus.DI
{
    public static class RepositoryInjection
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<INewsRepository, NewsRepository>();

        }
    }
}
