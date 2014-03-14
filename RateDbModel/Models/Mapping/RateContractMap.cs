using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateContractMap : EntityTypeConfiguration<RateContract>
    {
        public RateContractMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BookingType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RateContract");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RateId).HasColumnName("RateId");
            this.Property(t => t.AvailableFrom).HasColumnName("AvailableFrom");
            this.Property(t => t.AvailableTo).HasColumnName("AvailableTo");
            this.Property(t => t.MaxAvailabilty).HasColumnName("MaxAvailabilty");
            this.Property(t => t.IsWeekendRateDifferent).HasColumnName("IsWeekendRateDifferent");
            this.Property(t => t.IsFreeSale).HasColumnName("IsFreeSale");
            this.Property(t => t.WeekEndFare).HasColumnName("WeekEndFare");
            this.Property(t => t.MidweekFare).HasColumnName("MidweekFare");
            this.Property(t => t.BookingType).HasColumnName("BookingType");
            this.Property(t => t.IsDefaultBoardBasisApplicable).HasColumnName("IsDefaultBoardBasisApplicable");
            this.Property(t => t.OverridePoliciesId).HasColumnName("OverridePoliciesId");

            // Relationships
            this.HasRequired(t => t.Rate)
                .WithMany(t => t.RateContracts)
                .HasForeignKey(d => d.RateId);
            this.HasOptional(t => t.RateContractPolicy)
                .WithMany(t => t.RateContracts)
                .HasForeignKey(d => d.OverridePoliciesId);

        }
    }
}
