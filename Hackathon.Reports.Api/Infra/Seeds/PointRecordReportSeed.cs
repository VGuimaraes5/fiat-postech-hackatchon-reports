using Hackathon.Reports.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Reports.Api.Infra.Seeds;

public static class PointRecordReportSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PointRecordReportEntity>().HasData(
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 1), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"18:00:00\"}]", UserIdentification = "seed" },

            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 4), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 5), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 6), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:30:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 7), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 8), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },

            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 11), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 12), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:10:00\"}, {\"StartTime\":\"13:10:00\",\"EndTime\":\"17:20:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 13), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:40:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 14), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 15), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },

            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 18), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 19), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:10:00\"}, {\"StartTime\":\"13:10:00\",\"EndTime\":\"17:20:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 20), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:40:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 21), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 22), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },

            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 25), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 26), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:10:00\"}, {\"StartTime\":\"13:10:00\",\"EndTime\":\"17:20:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 27), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:40:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 28), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" },
            new PointRecordReportEntity { Id = Guid.NewGuid(), Date = new DateOnly(2024, 3, 29), Registers = "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", UserIdentification = "seed" }
        );
    }
}