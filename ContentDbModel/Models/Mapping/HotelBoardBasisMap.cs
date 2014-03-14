using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class HotelBoardBasisMap : EntityTypeConfiguration<HotelBoardBasis>
    {
        public HotelBoardBasisMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BoardBasisCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Description)
                .HasMaxLength(2048);

            this.Property(t => t.CostType)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.CostUnit)
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
            this.ToTable("HotelBoardBasises");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BoardBasisCode).HasColumnName("BoardBasisCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CostType).HasColumnName("CostType");
            this.Property(t => t.CostUnit).HasColumnName("CostUnit");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.Scope).HasColumnName("Scope");

            // Relationships
            this.HasRequired(t => t.BoardBasis)
                .WithMany(t => t.HotelBoardBasises)
                .HasForeignKey(d => new { d.BoardBasisCode, d.Scope });
            this.HasRequired(t => t.UserHotel)
                .WithMany(t => t.HotelBoardBasises)
                .HasForeignKey(d => new { d.HotelId, d.Scope });

        }
    }
}
