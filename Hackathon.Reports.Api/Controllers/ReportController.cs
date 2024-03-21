using Hackathon.Reports.Api.Domain.Interfaces.Services;
using Hackathon.Reports.Api.Domain.Models;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Reports.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private readonly IPointRecordReportService _pointRecordReportService;
    private readonly IPublishEndpoint _publisher;

    public ReportController(IPointRecordReportService pointRecordReportService, IPublishEndpoint publisher)
    {
        _pointRecordReportService = pointRecordReportService;
        _publisher = publisher;
    }

    [HttpGet]
    public async Task<IActionResult> GetUserReport([FromQuery] DateOnly date)
    {
        try
        {
            var result = await _pointRecordReportService.GetUserReportAsync(date);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> SendReport([FromBody] SendReportEvent model)
    {
        try
        {
            await _publisher.Publish(model);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}