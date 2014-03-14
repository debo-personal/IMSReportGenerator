using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class AirportMap : EntityTypeConfiguration<Airport>
    {
        public AirportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AirportCode, t.AirportName, t.CityCode, t.CityName, t.CountryCode, t.Longitude, t.Latitude, t.TimeZoneCode, t.IsDomestic, t.Preference });

            // Properties
            this.Property(t => t.AirportCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.AirportName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.CityCode)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.CityName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.StateCode)
                .HasMaxLength(5);

            this.Property(t => t.CountryCode)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Longitude)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Latitude)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TimeZoneCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Preference)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Airports");
            this.Property(t => t.AirportCode).HasColumnName("AirportCode");
            this.Property(t => t.AirportName).HasColumnName("AirportName");
            this.Property(t => t.CityCode).HasColumnName("CityCode");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.TimeZoneCode).HasColumnName("TimeZoneCode");
            this.Property(t => t.IsDomestic).HasColumnName("IsDomestic");
            this.Property(t => t.Preference).HasColumnName("Preference");
        }
    }
}
