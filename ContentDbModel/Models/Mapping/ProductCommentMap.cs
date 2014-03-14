using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ProductCommentMap : EntityTypeConfiguration<ProductComment>
    {
        public ProductCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProductType)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(2048);

            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.AddedByName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ProductComments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.AddedByName).HasColumnName("AddedByName");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.Scope).HasColumnName("Scope");

            // Relationships
            this.HasRequired(t => t.ProductType1)
                .WithMany(t => t.ProductComments)
                .HasForeignKey(d => d.ProductType);

        }
    }
}
