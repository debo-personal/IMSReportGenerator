using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class HotelSecondaryInformationMap : EntityTypeConfiguration<HotelSecondaryInformation>
    {
        public HotelSecondaryInformationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ClarifiHotelMappingId, t.Scope });

            // Properties
            this.Property(t => t.ClarifiHotelMappingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Category)
                .HasMaxLength(128);

            this.Property(t => t.Rating)
                .HasMaxLength(128);

            this.Property(t => t.DisplayName)
                .HasMaxLength(512);

            this.Property(t => t.ContactPerson)
                .HasMaxLength(512);

            this.Property(t => t.ContactEmailAddress)
                .HasMaxLength(512);

            this.Property(t => t.ContactPhoneCountryCode)
                .HasMaxLength(4);

            this.Property(t => t.ContactPhoneNumber)
                .HasMaxLength(32);

            this.Property(t => t.Description)
                .HasMaxLength(2048);

            this.Property(t => t.WeekendDays)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.CheckinDays)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.CheckoutDays)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.ContactFaxNumber)
                .HasMaxLength(32);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("HotelSecondaryInformation");
            this.Property(t => t.ClarifiHotelMappingId).HasColumnName("ClarifiHotelMappingId");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Rating).HasColumnName("Rating");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.ContactEmailAddress).HasColumnName("ContactEmailAddress");
            this.Property(t => t.ContactPhoneCountryCode).HasColumnName("ContactPhoneCountryCode");
            this.Property(t => t.ContactPhoneNumber).HasColumnName("ContactPhoneNumber");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.WeekendDays).HasColumnName("WeekendDays");
            this.Property(t => t.CheckinDays).HasColumnName("CheckinDays");
            this.Property(t => t.CheckoutDays).HasColumnName("CheckoutDays");
            this.Property(t => t.ContactFaxNumber).HasColumnName("ContactFaxNumber");
            this.Property(t => t.RecommendedInfantAge).HasColumnName("RecommendedInfantAge");
            this.Property(t => t.RecommededChildWithoutBedAge).HasColumnName("RecommededChildWithoutBedAge");
            this.Property(t => t.RecommendedChildWithBedAge).HasColumnName("RecommendedChildWithBedAge");
            this.Property(t => t.Scope).HasColumnName("Scope");

            // Relationships
            this.HasRequired(t => t.ClarifiHotelMapping)
                .WithMany(t => t.HotelSecondaryInformations)
                .HasForeignKey(d => d.ClarifiHotelMappingId);

        }
    }
}
