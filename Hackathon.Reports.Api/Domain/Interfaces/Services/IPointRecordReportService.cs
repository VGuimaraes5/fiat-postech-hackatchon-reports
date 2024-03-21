using Hackathon.Reports.Api.Domain.Models;

namespace Hackathon.Reports.Api.Domain.Interfaces.Services;

public interface IPointRecordReportService
{
    Task CreateAsync(CreatePointRecordEvent model);
    Task<RegisterResultModel> GetUserReportAsync(DateOnly date);
    Task SendReportAsync(SendReportEvent model);
}