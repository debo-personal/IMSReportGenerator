using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class AvailabilityMap : EntityTypeConfiguration<Availability>
    {
        public AvailabilityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RateId, t.AvailableDate });

            // Properties
            this.Property(t => t.RateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductType)
                .IsRequired()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("Availability");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.InventoryId).HasColumnName("InventoryId");
            this.Property(t => t.RateCodeId).HasColumnName("RateCodeId");
            this.Property(t => t.RateId).HasColumnName("RateId");
            this.Property(t => t.AvailableDate).HasColumnName("AvailableDate");
            this.Property(t => t.Allocated).HasColumnName("Allocated");
            this.Property(t => t.Booked).HasColumnName("Booked");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
        }
    }
}
