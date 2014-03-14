using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ProductTypeMap : EntityTypeConfiguration<ProductType>
    {
        public ProductTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductType1);

            // Properties
            this.Property(t => t.ProductType1)
                .IsRequired()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ProductType");
            this.Property(t => t.ProductType1).HasColumnName("ProductType");
        }
    }
}
