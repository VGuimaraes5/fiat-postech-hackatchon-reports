using Hackathon.Reports.Api.Consumers;
using MassTransit;

namespace Hackathon.Reports.Api.Infra.Configurations;

public static class ConfigureBus
{
    public static IServiceCollection ConfigBus(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMassTransit(config =>
        {
            config.AddConsumer<QueueCreatePointRecordReportConsumer>();
            config.AddConsumer<QueueSendReportConsumer>();

            config.UsingRabbitMq((ctx, busConfigurator) =>
            {
                busConfigurator.Host(configuration.GetConnectionString("RabbitMQ"));
                busConfigurator.ConfigureEndpoints(ctx);
            });
        });

        return services;
    }
}
