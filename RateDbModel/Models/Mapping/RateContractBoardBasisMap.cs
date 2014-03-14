using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RateDbModel.Models.Mapping
{
    public class RateContractBoardBasisMap : EntityTypeConfiguration<RateContractBoardBasis>
    {
        public RateContractBoardBasisMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RateContractId, t.HotelBoardBasisId });

            // Properties
            this.Property(t => t.RateContractId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HotelBoardBasisId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RateContractBoardBasises");
            this.Property(t => t.RateContractId).HasColumnName("RateContractId");
            this.Property(t => t.HotelBoardBasisId).HasColumnName("HotelBoardBasisId");

            // Relationships
            this.HasRequired(t => t.RateContract)
                .WithMany(t => t.RateContractBoardBasises)
                .HasForeignKey(d => d.RateContractId);

        }
    }
}
