using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class AdditionalInformationMap : EntityTypeConfiguration<AdditionalInformation>
    {
        public AdditionalInformationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProductType)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Title)
                .HasMaxLength(256);

            this.Property(t => t.Visibility)
                .HasMaxLength(32);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("AdditionalInformation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Visibility).HasColumnName("Visibility");
            this.Property(t => t.Scope).HasColumnName("Scope");

            // Relationships
            this.HasRequired(t => t.ProductType1)
                .WithMany(t => t.AdditionalInformations)
                .HasForeignKey(d => d.ProductType);

        }
    }
}
