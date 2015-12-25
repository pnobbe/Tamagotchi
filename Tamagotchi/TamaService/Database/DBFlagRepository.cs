using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamaService.Database
{
    public class DBFlagRepository : IFlagRepository
    {
        private DatabaseContext _database;
        public DBFlagRepository(DatabaseContext db)
        {
            _database = db;
        }

        public void create(TamaFlags newTama)
        {
            _database.Tamaflags.Add(newTama);
            _database.SaveChanges();
        }

        public List<TamaFlags> getList()
        {
            return _database.Tamaflags.ToList();
        }

        public bool update(TamaFlags tama)
        {
            _database.SaveChanges();
            return true;
        }
    }
}