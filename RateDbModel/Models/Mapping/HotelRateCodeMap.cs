using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class HotelRateCodeMap : EntityTypeConfiguration<HotelRateCode>
    {
        public HotelRateCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CheckInDays)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.CheckOutDays)
                .IsFixedLength()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("HotelRateCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RateCodeId).HasColumnName("RateCodeId");
            this.Property(t => t.CheckInDays).HasColumnName("CheckInDays");
            this.Property(t => t.CheckOutDays).HasColumnName("CheckOutDays");
            this.Property(t => t.MinimumStay).HasColumnName("MinimumStay");
            this.Property(t => t.MaximumStay).HasColumnName("MaximumStay");

            // Relationships
            this.HasRequired(t => t.RateCode)
                .WithMany(t => t.HotelRateCodes)
                .HasForeignKey(d => d.RateCodeId);

        }
    }
}
