using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class HotelMigrationLogMap : EntityTypeConfiguration<HotelMigrationLog>
    {
        public HotelMigrationLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NewId, t.OldId, t.TableName });

            // Properties
            this.Property(t => t.NewId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OldId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("HotelMigrationLogs");
            this.Property(t => t.NewId).HasColumnName("NewId");
            this.Property(t => t.OldId).HasColumnName("OldId");
            this.Property(t => t.TableName).HasColumnName("TableName");
        }
    }
}
