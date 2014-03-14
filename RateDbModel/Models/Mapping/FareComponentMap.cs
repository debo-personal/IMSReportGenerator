using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class FareComponentMap : EntityTypeConfiguration<FareComponent>
    {
        public FareComponentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ComponentType)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ChargeType)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("FareComponents");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ComponentType).HasColumnName("ComponentType");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ChargeType).HasColumnName("ChargeType");
            this.Property(t => t.RateCodeId).HasColumnName("RateCodeId");

            // Relationships
            this.HasRequired(t => t.RateCode)
                .WithMany(t => t.FareComponents)
                .HasForeignKey(d => d.RateCodeId);

        }
    }
}
