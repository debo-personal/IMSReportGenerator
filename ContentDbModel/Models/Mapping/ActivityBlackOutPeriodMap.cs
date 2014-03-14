using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ActivityBlackOutPeriodMap : EntityTypeConfiguration<ActivityBlackOutPeriod>
    {
        public ActivityBlackOutPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ActivityBlackOutPeriod");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OptionId).HasColumnName("OptionId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");

            // Relationships
            this.HasRequired(t => t.ActivityOption)
                .WithMany(t => t.ActivityBlackOutPeriods)
                .HasForeignKey(d => d.OptionId);

        }
    }
}
