using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class HotelAmenityMap : EntityTypeConfiguration<HotelAmenity>
    {
        public HotelAmenityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("HotelAmenities");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AmenityId).HasColumnName("AmenityId");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.Scope).HasColumnName("Scope");

            // Relationships
            this.HasRequired(t => t.Amenity)
                .WithMany(t => t.HotelAmenities)
                .HasForeignKey(d => d.AmenityId);
            this.HasRequired(t => t.UserHotel)
                .WithMany(t => t.HotelAmenities)
                .HasForeignKey(d => new { d.HotelId, d.Scope });

        }
    }
}
