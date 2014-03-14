using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class OccupancyMap : EntityTypeConfiguration<Occupancy>
    {
        public OccupancyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProductType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LastModifiedBy)
                .HasMaxLength(128);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Occupancies");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MinAdt).HasColumnName("MinAdt");
            this.Property(t => t.MaxAdt).HasColumnName("MaxAdt");
            this.Property(t => t.RecAdt).HasColumnName("RecAdt");
            this.Property(t => t.MinChd).HasColumnName("MinChd");
            this.Property(t => t.MaxChd).HasColumnName("MaxChd");
            this.Property(t => t.RecChd).HasColumnName("RecChd");
            this.Property(t => t.MinChdNoBed).HasColumnName("MinChdNoBed");
            this.Property(t => t.MaxChdNoBed).HasColumnName("MaxChdNoBed");
            this.Property(t => t.RecChdNoBed).HasColumnName("RecChdNoBed");
            this.Property(t => t.MinInf).HasColumnName("MinInf");
            this.Property(t => t.MaxInf).HasColumnName("MaxInf");
            this.Property(t => t.RecInf).HasColumnName("RecInf");
            this.Property(t => t.MinTotal).HasColumnName("MinTotal");
            this.Property(t => t.MaxTotal).HasColumnName("MaxTotal");
            this.Property(t => t.RecTotal).HasColumnName("RecTotal");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
