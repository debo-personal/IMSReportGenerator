using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.StateCode, t.CountryCode });

            // Properties
            this.Property(t => t.StateCode)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.CountryCode)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.StateName)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("States");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.StateName).HasColumnName("StateName");
        }
    }
}
