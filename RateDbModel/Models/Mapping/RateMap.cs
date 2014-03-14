using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateMap : EntityTypeConfiguration<Rate>
    {
        public RateMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProductType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PricingType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Rate");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RateCodeId).HasColumnName("RateCodeId");
            this.Property(t => t.InventoryId).HasColumnName("InventoryId");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.PricingType).HasColumnName("PricingType");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasRequired(t => t.RateCode)
                .WithMany(t => t.Rates)
                .HasForeignKey(d => d.RateCodeId);

        }
    }
}
