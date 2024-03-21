using Hackathon.Reports.Api.Domain.Interfaces.Services;
using Hackathon.Reports.Api.Domain.Models;
using MassTransit;

namespace Hackathon.Reports.Api.Consumers;

public class QueueSendReportConsumer : IConsumer<SendReportEvent>
{
    private readonly IPointRecordReportService _pointRecordReportService;
    private readonly ILogger<QueueSendReportConsumer> _logger;

    public QueueSendReportConsumer(
        IPointRecordReportService pointRecordReportService,
        ILogger<QueueSendReportConsumer> logger)
    {
        _pointRecordReportService = pointRecordReportService;
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<SendReportEvent> context)
    {
        try
        {
            await _pointRecordReportService.SendReportAsync(context.Message);

            _logger.LogInformation("Register with success!");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex.Message}");
        }
    }
}