using Hackathon.Reports.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hackathon.Reports.Api.Infra.Mappings;

public class PointRecordReportMapping : IEntityTypeConfiguration<PointRecordReportEntity>
{
    public void Configure(EntityTypeBuilder<PointRecordReportEntity> builder)
    {
        builder
            .ToTable("tb_point_record_report");

        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.UserIdentification);

        builder
            .HasIndex(p => new { p.UserIdentification, p.Date })
            .IsUnique();
    }
}