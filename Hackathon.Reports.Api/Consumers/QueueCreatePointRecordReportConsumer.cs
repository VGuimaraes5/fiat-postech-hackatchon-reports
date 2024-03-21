using Hackathon.Reports.Api.Domain.Interfaces.Services;
using Hackathon.Reports.Api.Domain.Models;
using MassTransit;

namespace Hackathon.Reports.Api.Consumers;

public class QueueCreatePointRecordReportConsumer : IConsumer<CreatePointRecordEvent>
{
    private readonly IPointRecordReportService _pointRecordReportService;
    private readonly ILogger<QueueCreatePointRecordReportConsumer> _logger;

    public QueueCreatePointRecordReportConsumer(
        IPointRecordReportService pointRecordReportService,
        ILogger<QueueCreatePointRecordReportConsumer> logger)
    {
        _pointRecordReportService = pointRecordReportService;
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<CreatePointRecordEvent> context)
    {
        try
        {
            await _pointRecordReportService.CreateAsync(context.Message);

            _logger.LogInformation("Register with success!");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex.Message}");
        }
    }
}