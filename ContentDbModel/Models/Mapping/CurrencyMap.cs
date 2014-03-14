using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class CurrencyMap : EntityTypeConfiguration<Currency>
    {
        public CurrencyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CurrencyCode, t.CurrencyName });

            // Properties
            this.Property(t => t.CurrencyCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.CurrencyName)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("Currencies");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.CurrencyName).HasColumnName("CurrencyName");
        }
    }
}
