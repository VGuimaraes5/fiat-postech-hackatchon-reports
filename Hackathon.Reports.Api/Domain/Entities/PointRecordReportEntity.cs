using Hackathon.Reports.Api.Domain.Entities.Base;

namespace Hackathon.Reports.Api.Domain.Entities;

public class PointRecordReportEntity : BaseEntity
{
    public required DateOnly Date { get; set; }
    public required string UserIdentification { get; set; }
    public required string Registers { get; set; }
}