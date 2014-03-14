using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            // Primary Key
            this.HasKey(t => t.CountryCode);

            // Properties
            this.Property(t => t.CountryCode)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Countries");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
        }
    }
}
