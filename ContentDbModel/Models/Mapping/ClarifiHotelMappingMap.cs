using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ClarifiHotelMappingMap : EntityTypeConfiguration<ClarifiHotelMapping>
    {
        public ClarifiHotelMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LastModifiedBy)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ClarifiHotelMappings");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ClarifiHotelId).HasColumnName("ClarifiHotelId");
            this.Property(t => t.IsNewHotel).HasColumnName("IsNewHotel");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
        }
    }
}
