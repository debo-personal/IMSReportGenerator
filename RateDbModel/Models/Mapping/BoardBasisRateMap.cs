using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class BoardBasisRateMap : EntityTypeConfiguration<BoardBasisRate>
    {
        public BoardBasisRateMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LastModifiedBy)
                .HasMaxLength(128);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("BoardBasisRates");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Adult).HasColumnName("Adult");
            this.Property(t => t.ChildWithBed).HasColumnName("ChildWithBed");
            this.Property(t => t.ChildWithoutBed).HasColumnName("ChildWithoutBed");
            this.Property(t => t.Infant).HasColumnName("Infant");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.BoardBasisPricingId).HasColumnName("BoardBasisPricingId");
            this.Property(t => t.RoomCost).HasColumnName("RoomCost");

            // Relationships
            this.HasRequired(t => t.BoardBasisPricing)
                .WithMany(t => t.BoardBasisRates)
                .HasForeignKey(d => d.BoardBasisPricingId);

        }
    }
}
