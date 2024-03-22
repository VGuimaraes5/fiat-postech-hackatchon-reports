using Hackathon.Reports.Api.Domain.Entities;
using Hackathon.Reports.Api.Domain.Interfaces.Repositories;
using Hackathon.Reports.Api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Reports.Api.Infra.Repositories;

public class PointRecordReportRepository : IPointRecordReportRepository
{
    private readonly DataContext _context;
    private readonly DbSet<PointRecordReportEntity> _dbSet;

    public PointRecordReportRepository(DataContext context)
    {
        _context = context;
        _dbSet = context.Set<PointRecordReportEntity>();
    }

    public async Task CreateAsync(PointRecordReportEntity entity)
    {
        entity.CreatedAt = DateTime.Now;

        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<PointRecordReportEntity?> GetByUserAndDateAsync(string userIdentification, DateOnly date)
    {
        return await _dbSet.FirstOrDefaultAsync(
            x => x.UserIdentification == userIdentification &&
            x.Date == date);
    }

    public async Task<List<PointRecordReportEntity>?> GetByUserAndDateRangeAsync(string userIdentification, DateOnly startDate, DateOnly endDate)
    {
        return await _dbSet.Where(
            x => x.UserIdentification == userIdentification &&
            x.Date >= startDate && x.Date <= endDate)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task UpdateAsync(PointRecordReportEntity entity)
    {
        entity.UpdatedAt = DateTime.Now;

        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }
}