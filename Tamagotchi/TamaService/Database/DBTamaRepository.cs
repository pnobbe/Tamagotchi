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


        public Tamagotchi create(Tamagotchi newTama)
        {
            DBTamagotchi x = TamaToDB(newTama);
            _database.SaveChanges();
            newTama.Id = x.Id;
            return newTama;
        }

        public List<Tamagotchi> getList()
        {

            if (_database.Tamagotchis.Count() == null)
            {

                return new List<Tamagotchi>();
            }
            _database.SaveChanges();

            // Loop and Update all
            foreach (DBTamagotchi x in _database.Tamagotchis)
                _database.Entry(x).Reload();

            // CONVERT
            List<Tamagotchi> ret = new List<Tamagotchi>();

            foreach (DBTamagotchi x in _database.Tamagotchis)
            {
                ret.Add(DBToTama(x));
            }

            return ret;
        }

        public bool update(Tamagotchi tama)
        {
            TamaToDB(tama);
            _database.SaveChanges();
            return true;
        }

        public DateTime RepoTime()
        {
            var dQuery = _database.Database.SqlQuery<DateTime>("SELECT GETDATE() ");
            Random rnd = new Random();
            return dQuery.AsEnumerable().First();
        }

        private DBTamagotchi TamaToDB(Tamagotchi tama)
        {
            DBTamagotchi t;
            Boolean newEntry = false;
            if (_database.Tamagotchis.Where(c => c.Id == tama.Id).Count() == 0)
            {
                // NEW
                t = new DBTamagotchi();
                newEntry = true;
            }
            else
            {
                t = _database.Tamagotchis.First(c => c.Id == tama.Id);
            }
            t.ActionDone = tama.ActionDone;
            t.Boredom = tama.Boredom;
            t.CreationData = tama.CreationData;
            t.Flags = FlagToDB(tama.Flags);
            t.Health = tama.Health;
            t.Hunger = tama.Hunger;
            t.Id = tama.Id;
            t.ImgId = tama.ImgId;
            t.isDead = tama.isDead;
            t.LastUpdate = tama.LastUpdate;
            t.LastAction = tama.lastAction;
            t.Name = tama.Name;
            t.Sleep = tama.Sleep;

            if (newEntry)
                _database.Tamagotchis.Add(t);
            _database.SaveChanges();
            return t;
        }

        private DBTamaFlags FlagToDB(TamaFlags flag)
        {
            DBTamaFlags db;
            Boolean newEntry = false;
            if (_database.Tamaflags.Where(c => c.ID == flag.ID).Count() == 0)
            {
                // NEW
                db = new DBTamaFlags();
                newEntry = true;
            }
            else
            {
                db = _database.Tamaflags.First(c => c.ID == flag.ID);
            }

            db.Crazy = flag.Crazy;
            db.Honger = flag.Honger;
            db.ID = flag.ID;
            db.Isolatie = flag.Isolatie;
            db.Munchies = flag.Munchies;
            db.Slaaptekort = flag.Slaaptekort;
            db.Topatleet = flag.Topatleet;
            db.Vermoeidheid = flag.Vermoeidheid;
            db.Verveling = flag.Verveling;
            db.Voedseltekort = flag.Voedseltekort;

            if (newEntry)
                _database.Tamaflags.Add(db);
            _database.SaveChanges();

            return db;
        }

        private TamaFlags DBToFlag(DBTamaFlags flag)
        {
            TamaFlags f = new TamaFlags();
            f.Crazy = flag.Crazy;
            f.Honger = flag.Honger;
            f.ID = flag.ID;
            f.Isolatie = flag.Isolatie;
            f.Munchies = flag.Munchies;
            f.Slaaptekort = flag.Slaaptekort;
            f.Topatleet = flag.Topatleet;
            f.Vermoeidheid = flag.Vermoeidheid;
            f.Verveling = flag.Verveling;
            f.Voedseltekort = flag.Voedseltekort;
            return f;
        }

        private Tamagotchi DBToTama(DBTamagotchi tama)
        {
            Tamagotchi t = new Tamagotchi();
            t.ActionDone = tama.ActionDone;
            t.Boredom = tama.Boredom;
            t.CreationData = tama.CreationData;
            t.Flags = DBToFlag(tama.Flags);
            t.Health = tama.Health;
            t.Hunger = tama.Hunger;
            t.Id = tama.Id;
            t.ImgId = tama.ImgId;
            t.isDead = tama.isDead;
            t.LastUpdate = tama.LastUpdate;
            t.Name = tama.Name;
            t.lastAction = tama.LastAction;
            t.Sleep = tama.Sleep;
            return t;
        }
    }
}