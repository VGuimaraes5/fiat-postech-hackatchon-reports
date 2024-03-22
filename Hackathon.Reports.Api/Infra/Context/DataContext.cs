using Hackathon.Reports.Api.Domain.Entities;
using Hackathon.Reports.Api.Infra.Mappings;
using Hackathon.Reports.Api.Infra.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Reports.Api.Infra.Context;

public class DataContext : DbContext
{
    public DbSet<PointRecordReportEntity>? PointRecord { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PointRecordReportMapping());

        PointRecordReportSeed.Seed(modelBuilder);
    }
}
