using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class UserHotelMap : EntityTypeConfiguration<UserHotel>
    {
        public UserHotelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ClarifiHotelMappingId, t.Scope });

            // Properties
            this.Property(t => t.ClarifiHotelMappingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HotelName)
                .HasMaxLength(128);

            this.Property(t => t.Address1)
                .HasMaxLength(128);

            this.Property(t => t.Address2)
                .HasMaxLength(128);

            this.Property(t => t.CityCode)
                .HasMaxLength(5);

            this.Property(t => t.CityName)
                .HasMaxLength(64);

            this.Property(t => t.StateCode)
                .HasMaxLength(5);

            this.Property(t => t.StateName)
                .HasMaxLength(128);

            this.Property(t => t.ZipCode)
                .HasMaxLength(16);

            this.Property(t => t.CountryCode)
                .HasMaxLength(2);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(64);

            this.Property(t => t.FaxNumber)
                .HasMaxLength(64);

            this.Property(t => t.ChainCode)
                .HasMaxLength(256);

            this.Property(t => t.WebsiteUrl)
                .HasMaxLength(100);

            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LastModifiedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PhoneCountryCode)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("UserHotels");
            this.Property(t => t.ClarifiHotelMappingId).HasColumnName("ClarifiHotelMappingId");
            this.Property(t => t.HotelName).HasColumnName("HotelName");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.CityCode).HasColumnName("CityCode");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.FaxNumber).HasColumnName("FaxNumber");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.StopSale).HasColumnName("StopSale");
            this.Property(t => t.ChainCode).HasColumnName("ChainCode");
            this.Property(t => t.WebsiteUrl).HasColumnName("WebsiteUrl");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.PhoneCountryCode).HasColumnName("PhoneCountryCode");

            // Relationships
            this.HasRequired(t => t.ClarifiHotelMapping)
                .WithMany(t => t.UserHotels)
                .HasForeignKey(d => d.ClarifiHotelMappingId);

        }
    }
}
