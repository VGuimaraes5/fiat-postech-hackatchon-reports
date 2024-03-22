using Hackathon.Reports.Api.Domain.Enums;

namespace Hackathon.Reports.Api.Domain.Models;

public class CreatePointRecordEvent
{
    public required DateTime RegisterDate { get; set; }
    public required string UserIdentification { get; set; }
    public PointRecordTypeEnum Type { get; set; }
}