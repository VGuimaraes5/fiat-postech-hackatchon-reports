using Hackathon.Reports.Api.Domain.Interfaces.Repositories;

namespace Hackathon.Reports.Api.Infra.Repositories;

public class EmailRepository : IEmailRepository
{
    private readonly HttpClient _client;
    private readonly ILogger<EmailRepository> _logger;

    public EmailRepository(IConfiguration configuration, ILogger<EmailRepository> logger)
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {configuration["EmailToken"]}");
        _logger = logger;
    }

    public async Task SendAsync(string to, string html)
    {
        var result = await _client.PostAsJsonAsync("https://api.mailersend.com/v1/email", new
        {
            from = new
            {
                email = "info@trial-0p7kx4xq1r2g9yjr.mlsender.net"
            },
            to = new List<object>
            {
                new {
                    email = to
                }
            },
            subject = "Relatório de pontos",
            text = "Relatório de pontos",
            html = html
        });

        if (result.IsSuccessStatusCode)
            _logger.LogInformation("Success send e-mail!");
        else
            _logger.LogInformation("Error send e-mail!");

    }
}