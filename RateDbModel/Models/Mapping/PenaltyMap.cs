using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class PenaltyMap : EntityTypeConfiguration<Penalty>
    {
        public PenaltyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PenaltyType)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ChargeType)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.DurationType)
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("Penalties");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PenaltyType).HasColumnName("PenaltyType");
            this.Property(t => t.ChargeType).HasColumnName("ChargeType");
            this.Property(t => t.ApplicableDurationBeforeCheckin).HasColumnName("ApplicableDurationBeforeCheckin");
            this.Property(t => t.DurationType).HasColumnName("DurationType");
            this.Property(t => t.RateCodeId).HasColumnName("RateCodeId");
            this.Property(t => t.RateContractId).HasColumnName("RateContractId");

            // Relationships
            this.HasOptional(t => t.RateCode)
                .WithMany(t => t.Penalties)
                .HasForeignKey(d => d.RateCodeId);
            this.HasOptional(t => t.RateContract)
                .WithMany(t => t.Penalties)
                .HasForeignKey(d => d.RateContractId);

        }
    }
}
