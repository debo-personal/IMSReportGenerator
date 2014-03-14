using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class HotelRoomMap : EntityTypeConfiguration<HotelRoom>
    {
        public HotelRoomMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Description)
                .HasMaxLength(2048);

            this.Property(t => t.BedType)
                .HasMaxLength(128);

            this.Property(t => t.SaleType)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LastModifiedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("HotelRooms");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserHotelId).HasColumnName("UserHotelId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsAgeRequired).HasColumnName("IsAgeRequired");
            this.Property(t => t.MaxCapacity).HasColumnName("MaxCapacity");
            this.Property(t => t.BedType).HasColumnName("BedType");
            this.Property(t => t.BedCount).HasColumnName("BedCount");
            this.Property(t => t.SaleType).HasColumnName("SaleType");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.Scope).HasColumnName("Scope");

            // Relationships
            this.HasRequired(t => t.ClarifiHotelMapping)
                .WithMany(t => t.HotelRooms)
                .HasForeignKey(d => d.UserHotelId);

        }
    }
}
