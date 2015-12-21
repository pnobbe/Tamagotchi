using System.Data.Entity;

namespace TamaService
{
    public class Database : DbContext
    {
        public Database() : base("name=TamaString")
        {
        }

        public DbSet<Tamagotchi> Tamagotchis { get; set; }

        public DbSet<TamaFlags> Tamaflags { get; set; }
    }
}