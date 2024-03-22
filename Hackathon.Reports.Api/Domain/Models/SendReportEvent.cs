namespace Hackathon.Reports.Api.Domain.Models;

public class SendReportEvent
{
    public required string EmailTo { get; set; }
    public required DateOnly Date { get; set; }
    public required string UserIdentification { get; set; }
}