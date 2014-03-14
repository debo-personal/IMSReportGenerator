using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ActivityMap : EntityTypeConfiguration<Activity>
    {
        public ActivityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Category)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Vendor)
                .HasMaxLength(128);

            this.Property(t => t.Address1)
                .HasMaxLength(128);

            this.Property(t => t.Address2)
                .HasMaxLength(128);

            this.Property(t => t.CityCode)
                .HasMaxLength(5);

            this.Property(t => t.CityName)
                .HasMaxLength(128);

            this.Property(t => t.StateCode)
                .HasMaxLength(128);

            this.Property(t => t.StateName)
                .HasMaxLength(128);

            this.Property(t => t.CountryCode)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ZipCode)
                .HasMaxLength(32);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(64);

            this.Property(t => t.PhoneCountryCode)
                .HasMaxLength(5);

            this.Property(t => t.Email)
                .HasMaxLength(256);

            this.Property(t => t.ContactName)
                .HasMaxLength(256);

            this.Property(t => t.WeekEndDays)
                .IsFixedLength()
                .HasMaxLength(7);

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
            this.ToTable("Activities");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Vendor).HasColumnName("Vendor");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.CityCode).HasColumnName("CityCode");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.PhoneCountryCode).HasColumnName("PhoneCountryCode");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.WeekEndDays).HasColumnName("WeekEndDays");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
