using System.Data.Entity;

namespace TamaService
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=TamaString")
        {
        }

        public DbSet<Tamagotchi> Tamagotchis { get; set; }

        public DbSet<TamaFlags> Tamaflags { get; set; }
    }
}