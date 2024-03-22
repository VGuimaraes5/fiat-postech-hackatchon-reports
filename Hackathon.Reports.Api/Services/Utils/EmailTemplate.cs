using Hackathon.Reports.Api.Domain.Models;

namespace Hackathon.Reports.Api.Services.Utils;

public static class EmailTemplate
{
    public static string Get(RegisterResultModel? result)
    {
        var body = "";

        result?.Registers?.ForEach(register =>
        {
            body += @$"
                <tr>
                    <td style=""border: 1px solid black; text-align: center"">{register.WeekDay}</td>
                    <td style=""border: 1px solid black; text-align: center"">{register.Date.ToString("dd/MM/yyyy")}</td>
                    <td style=""border: 1px solid black; text-align: center"">{register.Hours}</td>
                    <td style=""border: 1px solid black; text-align: center"">{register.TotalHours}</td>
                </tr>
            ";
        });

        return @$"
            <table style=""border: 1px solid black"">
                <thead>
                    <th style=""border: 1px solid black"" width=""130px"">Dia da semana</th>
                    <th style=""border: 1px solid black"" width=""130px"">Data</th>
                    <th style=""border: 1px solid black"">Horários</th>
                    <th style=""border: 1px solid black"">Total de horas trabalhadas</th>
                </thead>
                <tbody>
                    {body}
                </tbody>
            </table>
        ";
    }
}