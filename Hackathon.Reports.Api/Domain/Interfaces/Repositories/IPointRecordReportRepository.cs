using Hackathon.Reports.Api.Domain.Entities;

namespace Hackathon.Reports.Api.Domain.Interfaces.Repositories;

public interface IPointRecordReportRepository
{
    Task CreateAsync(PointRecordReportEntity entity);
    Task<PointRecordReportEntity?> GetByUserAndDateAsync(string userIdentification, DateOnly date);
    Task<List<PointRecordReportEntity>?> GetByUserAndDateRangeAsync(string userIdentification, DateOnly startDate, DateOnly endDate);
    Task UpdateAsync(PointRecordReportEntity entity);
}