using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CodeFirstBasic.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PatikaFirstDbContext>
    {
        public PatikaFirstDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PatikaFirstDbContext>();
            optionsBuilder.UseSqlite("Data Source=PatikaCodeFirstDb1.db"); // Bağlantı dizesini buraya ekleyin

            return new PatikaFirstDbContext(optionsBuilder.Options);
        }
    }
}
