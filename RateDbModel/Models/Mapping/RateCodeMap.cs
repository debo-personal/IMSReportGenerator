using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateCodeMap : EntityTypeConfiguration<RateCode>
    {
        public RateCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Code)
                .HasMaxLength(256);

            this.Property(t => t.Description)
                .HasMaxLength(2048);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.GeneralPolicies)
                .HasMaxLength(2048);

            this.Property(t => t.CurrencyCode)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ProductType)
                .HasMaxLength(16);

            this.Property(t => t.ContactPerson)
                .HasMaxLength(256);

            this.Property(t => t.ContactNumber)
                .HasMaxLength(128);

            this.Property(t => t.Email)
                .HasMaxLength(2048);

            // Table & Column Mappings
            this.ToTable("RateCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.MinAdvancePurchaseDays).HasColumnName("MinAdvancePurchaseDays");
            this.Property(t => t.MaxAdvancePurchaseDays).HasColumnName("MaxAdvancePurchaseDays");
            this.Property(t => t.StartOfBookingPeriod).HasColumnName("StartOfBookingPeriod");
            this.Property(t => t.EndOfBookingPeriod).HasColumnName("EndOfBookingPeriod");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.GeneralPolicies).HasColumnName("GeneralPolicies");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.IsNonRefundable).HasColumnName("IsNonRefundable");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.ContactNumber).HasColumnName("ContactNumber");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
