using System.Data.Entity;

namespace TamaService
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=TamaString")
        {
        }

        public DbSet<DBTamagotchi> Tamagotchis { get; set; }

        public DbSet<DBTamaFlags> Tamaflags { get; set; }
    }
}