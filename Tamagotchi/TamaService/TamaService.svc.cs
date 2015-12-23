using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TamaService.Domain.Interfaces;

namespace TamaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TamaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TamaService.svc or TamaService.svc.cs at the Solution Explorer and start debugging.
    public class TamaService : ITamaLogic
    {

        private Database x = new Database();

        public int AddTamagotchi(string name)
        {
            var dQuery = x.Database.SqlQuery<DateTime>("SELECT GETDATE() ");
            Random rnd = new Random();
            DateTime dbDate = dQuery.AsEnumerable().First();
            TamaFlags tf = new TamaFlags();
            x.Tamaflags.Add(tf);
            x.SaveChanges();
            Tamagotchi tama = new Tamagotchi();
            tama.Name = name;
            tama.CreationData = dbDate;
            tama.LastUpdate = dbDate;
            tama.FlagID = tf.ID;
            tama.ActionDone = dbDate;
            tama.ImgId = rnd.Next(1, 13);
            x.Tamagotchis.Add(tama);
            x.SaveChanges();

            return tama.Id;
        }


        public List<Tamagotchi> GetAllTamagotchi()
        {
           return x.Tamagotchis.ToList();
        }

        public Tamagotchi GetTamagotchi(int value)
        {
            if (x.Tamagotchis.Where(t => t.Id == value).Count() != 0)
            {
                Tamagotchi tama = x.Tamagotchis.First(t => t.Id == value);
                return tama;

            }
            else
            {
                return null;
            }
        }

        public TamaFlags GetFlag(int value)
        {
            if (x.Tamaflags.Where(t => t.ID == value).Count() != 0)
            {
                TamaFlags tama = x.Tamaflags.First(t => t.ID == value);
                return tama;

            }
            else
            {
                return null;
            }
        }

        public bool FlipFlag(string name, int tamaID)
        {

            Tamagotchi tama = GetTamagotchi(tamaID);

            if (tama == null)
                return false;

            if (x.Tamaflags.Where(t => t.ID == tama.FlagID).Count() != 0)
            {
                TamaFlags flags = x.Tamaflags.First(t => t.ID == tama.FlagID);

                switch(name)
                {
                    case "Crazy":
                        flags.Crazy = !flags.Crazy;
                        x.SaveChanges();
                        return true;
                    case "Honger":
                        flags.Honger = !flags.Honger;
                        x.SaveChanges();
                        return true;
                    case "Isolatie":
                        flags.Isolatie = !flags.Isolatie;
                        x.SaveChanges();
                        return true;
                    case "Munchies":
                        flags.Munchies = !flags.Munchies;
                        x.SaveChanges();
                        return true;
                    case "Slaaptekort":
                        flags.Slaaptekort = !flags.Slaaptekort;
                        x.SaveChanges();
                        return true;
                    case "Topatleet":
                        flags.Topatleet = !flags.Topatleet;
                        x.SaveChanges();
                        return true;
                    case "Vermoeidheid":
                        flags.Vermoeidheid = !flags.Vermoeidheid;
                        x.SaveChanges();
                        return true;
                    case "Verveling":
                        flags.Verveling = !flags.Verveling;
                        x.SaveChanges();
                        return true;
                    case "Voedseltekort":
                        flags.Voedseltekort = !flags.Voedseltekort;
                        x.SaveChanges();
                        return true;
                };

                return false;

            }
            else
            {
                return false;
            }
        }

        public bool UpdateTamagochi(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            TamaFlags flags = GetFlag(value);

            List<ISpelRegel> x = new List<ISpelRegel>();

            return false;
        }

        public bool Eat(int value)
        {
            // UPDATE UpdateTamagochi

            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            DateTime time;
            if(canExecute(tama, out time))
            {
                tama.Hunger = 0;
                time.AddSeconds(30);
                tama.ActionDone = time;
                x.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Sleep(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            DateTime time;
            if (canExecute(tama, out time))
            {

            }
            return false;
        }

        public bool Play(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            DateTime time;
            if (canExecute(tama, out time))
            {

            }
            return false;
        }

        public bool Workout(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            DateTime time;
            if (canExecute(tama, out time))
            {

            }
            return false;
        }

        public bool Hug(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            DateTime time;
            if (canExecute(tama, out time))
            {

            }
            return false;
        }

        private bool canExecute(Tamagotchi tama, out DateTime time)
        {
            time = DateTime.Now;
            if (tama == null || tama.isDead)
                return false;

            var dQuery = x.Database.SqlQuery<DateTime>("SELECT GETDATE() ");
            time = dQuery.AsEnumerable().First();

            return time >= tama.ActionDone;
        }
    }
}
