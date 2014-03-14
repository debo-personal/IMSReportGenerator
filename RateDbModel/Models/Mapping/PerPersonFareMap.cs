using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class PerPersonFareMap : EntityTypeConfiguration<PerPersonFare>
    {
        public PerPersonFareMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerPersonFare");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Adult).HasColumnName("Adult");
            this.Property(t => t.Child).HasColumnName("Child");
            this.Property(t => t.ExtraAdult).HasColumnName("ExtraAdult");
            this.Property(t => t.ExtraChild).HasColumnName("ExtraChild");
        }
    }
}
