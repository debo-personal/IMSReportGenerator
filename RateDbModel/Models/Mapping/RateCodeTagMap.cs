using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateCodeTagMap : EntityTypeConfiguration<RateCodeTag>
    {
        public RateCodeTagMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RateCodeId, t.TagId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RateCodeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TagId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RateCodeTags");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RateCodeId).HasColumnName("RateCodeId");
            this.Property(t => t.TagId).HasColumnName("TagId");

            // Relationships
            this.HasRequired(t => t.RateCode)
                .WithMany(t => t.RateCodeTags)
                .HasForeignKey(d => d.RateCodeId);
            this.HasRequired(t => t.Tag)
                .WithMany(t => t.RateCodeTags)
                .HasForeignKey(d => d.TagId);

        }
    }
}
