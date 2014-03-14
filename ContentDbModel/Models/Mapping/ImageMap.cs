using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ImageMap : EntityTypeConfiguration<Image>
    {
        public ImageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProductType)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.ImageUrl)
                .HasMaxLength(512);

            this.Property(t => t.Caption)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Images");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.Caption).HasColumnName("Caption");

            // Relationships
            this.HasRequired(t => t.ProductType1)
                .WithMany(t => t.Images)
                .HasForeignKey(d => d.ProductType);

        }
    }
}
