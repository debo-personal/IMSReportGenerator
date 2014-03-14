using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ContentDbModel.Models.Mapping
{
    public class BoardBasisMap : EntityTypeConfiguration<BoardBasis>
    {
        public BoardBasisMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Code, t.Scope });

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("BoardBasises");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsStandard).HasColumnName("IsStandard");
            this.Property(t => t.Scope).HasColumnName("Scope");
        }
    }
}
