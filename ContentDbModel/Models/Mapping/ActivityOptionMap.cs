using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ActivityOptionMap : EntityTypeConfiguration<ActivityOption>
    {
        public ActivityOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(2048);

            this.Property(t => t.UnitName)
                .HasMaxLength(128);

            this.Property(t => t.PricingType)
                .IsRequired()
                .HasMaxLength(50);

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
            this.ToTable("ActivityOptions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ActivityId).HasColumnName("ActivityId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.MaxAdults).HasColumnName("MaxAdults");
            this.Property(t => t.MaxChildren).HasColumnName("MaxChildren");
            this.Property(t => t.MinTotal).HasColumnName("MinTotal");
            this.Property(t => t.MaxTotal).HasColumnName("MaxTotal");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.PricingType).HasColumnName("PricingType");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.Scope).HasColumnName("Scope");

            // Relationships
            this.HasRequired(t => t.Activity)
                .WithMany(t => t.ActivityOptions)
                .HasForeignKey(d => d.ActivityId);

        }
    }
}
