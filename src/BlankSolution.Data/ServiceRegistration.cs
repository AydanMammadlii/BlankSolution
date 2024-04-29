using BlankSolution.Core.Repositories;
using BlankSolution.Data.Repostories;
using Microsoft.Extensions.DependencyInjection;

namespace BlankSolution.Data;

public static class ServiceRegistration
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGenreRepository, GenreRepository>();
    }
}
