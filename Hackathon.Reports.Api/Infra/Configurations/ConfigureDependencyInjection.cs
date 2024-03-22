using Hackathon.Reports.Api.Domain.Interfaces.Services;
using Hackathon.Reports.Api.Domain.Interfaces.Repositories;
using Hackathon.Reports.Api.Services;
using Hackathon.Reports.Api.Infra.Repositories;

namespace Hackathon.Reports.Api.Infra.Configurations;

public static class ConfigureDependencyInjection
{
    public static IServiceCollection ConfigDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<IPointRecordReportService, PointRecordReportService>();
        services.AddTransient<IIdentityService, IdentityService>();

        services.AddTransient<IPointRecordReportRepository, PointRecordReportRepository>();
        services.AddTransient<IEmailRepository, EmailRepository>();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        return services;
    }
}