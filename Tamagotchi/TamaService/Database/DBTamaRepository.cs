using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamaService.Database
{
    public class DBTamaRepository : ITamaRepository
    {

        private DatabaseContext _database;
        public DBTamaRepository(DatabaseContext db)
        {
            _database = db;
        }


        public void create(Tamagotchi newTama)
        {
            _database.Tamagotchis.Add(newTama);
            _database.SaveChanges();
        }

        public List<Tamagotchi> getList()
        {
            _database.SaveChanges();
            _database.Dispose();
            _database = new DatabaseContext();
            return _database.Tamagotchis.ToList();
        }

        public bool update(Tamagotchi tama)
        {
            _database.SaveChanges();
            return true;
        }

        public DateTime RepoTime()
        {
            var dQuery = _database.Database.SqlQuery<DateTime>("SELECT GETDATE() ");
            Random rnd = new Random();
            return dQuery.AsEnumerable().First();
        }
    }
}