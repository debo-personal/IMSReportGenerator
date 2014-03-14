using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class BoardBasisPricingMap : EntityTypeConfiguration<BoardBasisPricing>
    {
        public BoardBasisPricingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CurrencyCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LastModifiedBy)
                .HasMaxLength(128);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("BoardBasisPricings");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HotelBoardBasisId).HasColumnName("HotelBoardBasisId");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.Scope).HasColumnName("Scope");
        }
    }
}
