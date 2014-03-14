using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(3);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.StateCode)
                .HasMaxLength(2);

            this.Property(t => t.CountryCode)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Cities");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
        }
    }
}
