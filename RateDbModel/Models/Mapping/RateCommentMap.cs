using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateCommentMap : EntityTypeConfiguration<RateComment>
    {
        public RateCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(2048);

            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.AddedByName)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("RateComments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RateId).HasColumnName("RateId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.AddedByName).HasColumnName("AddedByName");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");

            // Relationships
            this.HasRequired(t => t.Rate)
                .WithMany(t => t.RateComments)
                .HasForeignKey(d => d.RateId);

        }
    }
}
