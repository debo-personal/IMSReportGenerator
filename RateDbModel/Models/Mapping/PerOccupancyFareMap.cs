using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class PerOccupancyFareMap : EntityTypeConfiguration<PerOccupancyFare>
    {
        public PerOccupancyFareMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerOccupancyFares");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.ExtraAdult).HasColumnName("ExtraAdult");
            this.Property(t => t.ExtraChildWithBed).HasColumnName("ExtraChildWithBed");
            this.Property(t => t.ExtraChildWithoutBed).HasColumnName("ExtraChildWithoutBed");
            this.Property(t => t.ExtraInfant).HasColumnName("ExtraInfant");
        }
    }
}
