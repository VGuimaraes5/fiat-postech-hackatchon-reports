using System.Text.Json;
using Hackathon.Reports.Api.Domain.Entities;
using Hackathon.Reports.Api.Domain.Interfaces.Repositories;
using Hackathon.Reports.Api.Domain.Interfaces.Services;
using Hackathon.Reports.Api.Domain.Models;
using Hackathon.Reports.Api.Services.Utils;

namespace Hackathon.Reports.Api.Services;

public class PointRecordReportService : IPointRecordReportService
{
    private readonly IPointRecordReportRepository _pointRecordReportRepository;
    private readonly IIdentityService _identityService;
    private readonly IEmailRepository _emailRepository;

    public PointRecordReportService(
        IPointRecordReportRepository pointRecordReportRepository,
        IIdentityService identityService,
        IEmailRepository emailRepository)
    {
        _pointRecordReportRepository = pointRecordReportRepository;
        _identityService = identityService;
        _emailRepository = emailRepository;
    }

    public async Task CreateAsync(CreatePointRecordEvent model)
    {
        try
        {
            var result = await _pointRecordReportRepository.GetByUserAndDateAsync(model.UserIdentification, DateOnly.FromDateTime(model.RegisterDate));

            if (result == null)
            {
                await _pointRecordReportRepository.CreateAsync(new PointRecordReportEntity
                {
                    Date = DateOnly.FromDateTime(model.RegisterDate),
                    UserIdentification = model.UserIdentification,
                    Registers = SetRegisters(model),
                });
            }
            else
            {
                result.Registers = SetRegisters(model, result.Registers);
                await _pointRecordReportRepository.UpdateAsync(result);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error: {ex.Message}");
        }
    }

    public async Task<RegisterResultModel> GetUserReportAsync(DateOnly date)
    {
        try
        {
            var userIdentification = _identityService.GetUserIdentification();

            return await GetReport(userIdentification, date);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error: {ex.Message}");
        }
    }

    public async Task SendReportAsync(SendReportEvent model)
    {
        try
        {
            var result = await GetReport(model.UserIdentification, model.Date);

            await _emailRepository.SendAsync(model.EmailTo, EmailTemplate.Get(result));
        }
        catch (Exception ex)
        {
            throw new Exception($"Error: {ex.Message}");
        }
    }

    private string SetRegisters(CreatePointRecordEvent model, string? registers = null)
    {
        if (registers == null)
        {
            var list = new List<RegisterModel>
            {
                new RegisterModel
                {
                    StartTime = TimeOnly.FromDateTime(model.RegisterDate)
                }
            };

            return JsonSerializer.Serialize(list);
        }

        var listUpdate = JsonSerializer.Deserialize<List<RegisterModel>>(registers);
        if (listUpdate == null)
            throw new InvalidDataException("Data registers is invalid!");

        var isUpdated = false;

        listUpdate.ForEach(item =>
        {
            if (item.EndTime == null)
            {
                item.EndTime = TimeOnly.FromDateTime(model.RegisterDate);
                isUpdated = true;
            }
        });

        if (!isUpdated)
        {
            listUpdate.Add(new RegisterModel
            {
                StartTime = TimeOnly.FromDateTime(model.RegisterDate)
            });
        }

        return JsonSerializer.Serialize(listUpdate);
    }

    private async Task<RegisterResultModel> GetReport(string userIdentification, DateOnly date)
    {
        var startDate = new DateOnly(date.Year, date.Month, 1);
        var endDate = new DateOnly(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

        var result = await _pointRecordReportRepository.GetByUserAndDateRangeAsync(userIdentification, startDate, endDate);
        if (result == null)
            throw new InvalidDataException("Result not found!");
        return new RegisterResultModel
        {
            UserIdentification = userIdentification,
            Registers = result.Select(item =>
            {
                var registers = JsonSerializer.Deserialize<List<RegisterModel>>(item.Registers);
                var registersString = "";
                int totalMinutes = 0;

                if (registers != null)
                {
                    registersString = string.Join(";", registers.Select(register => $"{register.StartTime} - {register.EndTime}"));

                    registers.ForEach(register =>
                    {
                        if (register.EndTime != null)
                        {
                            totalMinutes += (int)(register.EndTime - register.StartTime).Value.TotalMinutes;
                        }
                    });
                }

                return new RegisterDataResultModel
                {
                    Date = item.Date,
                    WeekDay = item.Date.DayOfWeek.ToString(),
                    Hours = registersString,
                    TotalHours = $"{Math.Floor(totalMinutes / 60d).ToString().PadLeft(2, '0')}:{(totalMinutes % 60).ToString().PadLeft(2, '0')}"
                };
            }).ToList()
        };
    }
}