using ePraksa.Application.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ePraksa.Infrastructure.Database;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration cfg)
    {
        services.AddDbContext<DatabaseContext>(opt =>
            opt.UseSqlServer(cfg.GetConnectionString("Default")));

        services.AddScoped<IAppDbContext>(sp => sp.GetRequiredService<DatabaseContext>());

        // ✅ Register DevSeeder
        services.AddScoped<DevSeeder>();

        return services;
    }
}
