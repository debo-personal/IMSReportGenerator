using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class ScopeSuppliersMappingMap : EntityTypeConfiguration<ScopeSuppliersMapping>
    {
        public ScopeSuppliersMappingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Scope, t.Supplier });

            // Properties
            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Supplier)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ScopeSuppliersMapping");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.Supplier).HasColumnName("Supplier");
        }
    }
}
