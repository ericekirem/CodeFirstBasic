using CodeFirstBasic.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        // Constructor (bağlantı dizesi alır)
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) { }

        // DbSet'ler tabloya karşılık gelirs
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Game> Game { get; set; }

        // Model oluşturma sırasında veritabanı yapılandırmasını özelleştirme
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movies"); // Movie tablosu oluşturulacak
            modelBuilder.Entity<Game>().ToTable("Games");  // Game tablosu oluşturulacak
        }

        // Bağlantı dizesi ayarı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=PatikaCodeFirstDb1.db");
            }
        }
    }
}
