using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateContractPolicyMap : EntityTypeConfiguration<RateContractPolicy>
    {
        public RateContractPolicyMap()
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

            this.Property(t => t.GeneralPolicies)
                .HasMaxLength(2048);

            // Table & Column Mappings
            this.ToTable("RateContractPolicies");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MinAdvancePurchaseDays).HasColumnName("MinAdvancePurchaseDays");
            this.Property(t => t.MaxAdvancePurchaseDays).HasColumnName("MaxAdvancePurchaseDays");
            this.Property(t => t.CheckInDays).HasColumnName("CheckInDays");
            this.Property(t => t.CheckOutDays).HasColumnName("CheckOutDays");
            this.Property(t => t.MinimumStay).HasColumnName("MinimumStay");
            this.Property(t => t.MaximumStay).HasColumnName("MaximumStay");
            this.Property(t => t.IsCheckinAllowed).HasColumnName("IsCheckinAllowed");
            this.Property(t => t.IsCheckoutAllowed).HasColumnName("IsCheckoutAllowed");
            this.Property(t => t.GeneralPolicies).HasColumnName("GeneralPolicies");
            this.Property(t => t.IsNonRefundable).HasColumnName("IsNonRefundable");
        }
    }
}
