namespace Hackathon.Reports.Api.Domain.Interfaces.Repositories;

public interface IEmailRepository
{
    Task SendAsync(string to, string html);
}