using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateContractOccupancyFareMappingMap : EntityTypeConfiguration<RateContractOccupancyFareMapping>
    {
        public RateContractOccupancyFareMappingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RateContractId, t.OccupancyId });

            // Properties
            this.Property(t => t.RateContractId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OccupancyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RateContractOccupancyFareMappings");
            this.Property(t => t.RateContractId).HasColumnName("RateContractId");
            this.Property(t => t.OccupancyId).HasColumnName("OccupancyId");
            this.Property(t => t.WeekdayFareId).HasColumnName("WeekdayFareId");
            this.Property(t => t.WeekendFareId).HasColumnName("WeekendFareId");
            this.Property(t => t.IsWeekendFareSeparate).HasColumnName("IsWeekendFareSeparate");

            // Relationships
            this.HasRequired(t => t.Occupancy)
                .WithMany(t => t.RateContractOccupancyFareMappings)
                .HasForeignKey(d => d.OccupancyId);
            this.HasRequired(t => t.PerOccupancyFare)
                .WithMany(t => t.RateContractOccupancyFareMappings)
                .HasForeignKey(d => d.WeekdayFareId);
            this.HasOptional(t => t.PerOccupancyFare1)
                .WithMany(t => t.RateContractOccupancyFareMappings1)
                .HasForeignKey(d => d.WeekendFareId);
            this.HasRequired(t => t.RateContract)
                .WithMany(t => t.RateContractOccupancyFareMappings)
                .HasForeignKey(d => d.RateContractId);

        }
    }
}
