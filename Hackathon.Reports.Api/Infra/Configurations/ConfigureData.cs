using Hackathon.Reports.Api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Reports.Api.Infra.Configurations;

public static class ConfigureData
{
    public static IServiceCollection ConfigContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<DataContext>(
            option =>
            {
                option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        );

        return services;
    }
}