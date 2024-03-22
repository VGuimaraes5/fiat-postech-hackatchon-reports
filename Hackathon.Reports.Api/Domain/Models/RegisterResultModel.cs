namespace Hackathon.Reports.Api.Domain.Models;

public class RegisterResultModel
{
    public required string UserIdentification { get; set; }
    public List<RegisterDataResultModel>? Registers { get; set; }
}

public class RegisterDataResultModel
{
    public required string WeekDay { get; set; }
    public required DateOnly Date { get; set; }
    public required string Hours { get; set; }
    public required string TotalHours { get; set; }
}