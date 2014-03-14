using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class PerUnitFareMap : EntityTypeConfiguration<PerUnitFare>
    {
        public PerUnitFareMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerUnitFare");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ExtraAdult).HasColumnName("ExtraAdult");
            this.Property(t => t.ExtraChild).HasColumnName("ExtraChild");
        }
    }
}
