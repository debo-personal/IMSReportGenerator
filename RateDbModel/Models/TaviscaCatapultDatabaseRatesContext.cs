using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RateDbModel.Models.Mapping;

namespace RateDbModel.Models
{
    public partial class TaviscaCatapultDatabaseRatesContext : DbContext
    {
        static TaviscaCatapultDatabaseRatesContext()
        {
            Database.SetInitializer<TaviscaCatapultDatabaseRatesContext>(null);
        }

        public TaviscaCatapultDatabaseRatesContext()
            : base("Name=TaviscaCatapultDatabaseRatesContext")
        {
        }

        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<BoardBasisPricing> BoardBasisPricings { get; set; }
        public DbSet<BoardBasisRate> BoardBasisRates { get; set; }
        public DbSet<FareComponent> FareComponents { get; set; }
        public DbSet<HotelRateCode> HotelRateCodes { get; set; }
        public DbSet<Occupancy> Occupancies { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<PerOccupancyFare> PerOccupancyFares { get; set; }
        public DbSet<PerPersonFare> PerPersonFares { get; set; }
        public DbSet<PerUnitFare> PerUnitFares { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<RateCode> RateCodes { get; set; }
        public DbSet<RateCodeTag> RateCodeTags { get; set; }
        public DbSet<RateComment> RateComments { get; set; }
        public DbSet<RateContract> RateContracts { get; set; }
        public DbSet<RateContractBoardBasis> RateContractBoardBasises { get; set; }
        public DbSet<RateContractOccupancyFareMapping> RateContractOccupancyFareMappings { get; set; }
        public DbSet<RateContractPolicy> RateContractPolicies { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C__RefactorLogMap());
            modelBuilder.Configurations.Add(new AvailabilityMap());
            modelBuilder.Configurations.Add(new BoardBasisPricingMap());
            modelBuilder.Configurations.Add(new BoardBasisRateMap());
            modelBuilder.Configurations.Add(new FareComponentMap());
            modelBuilder.Configurations.Add(new HotelRateCodeMap());
            modelBuilder.Configurations.Add(new OccupancyMap());
            modelBuilder.Configurations.Add(new PenaltyMap());
            modelBuilder.Configurations.Add(new PerOccupancyFareMap());
            modelBuilder.Configurations.Add(new PerPersonFareMap());
            modelBuilder.Configurations.Add(new PerUnitFareMap());
            modelBuilder.Configurations.Add(new RateMap());
            modelBuilder.Configurations.Add(new RateCodeMap());
            modelBuilder.Configurations.Add(new RateCodeTagMap());
            modelBuilder.Configurations.Add(new RateCommentMap());
            modelBuilder.Configurations.Add(new RateContractMap());
            modelBuilder.Configurations.Add(new RateContractBoardBasisMap());
            modelBuilder.Configurations.Add(new RateContractOccupancyFareMappingMap());
            modelBuilder.Configurations.Add(new RateContractPolicyMap());
            modelBuilder.Configurations.Add(new TagMap());
        }
    }
}
