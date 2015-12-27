using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TamaService.Database;
using TamaService.Domain.Interfaces;

namespace TamaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TamaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TamaService.svc or TamaService.svc.cs at the Solution Explorer and start debugging.
    public class TamaService : ITamaLogic
    {
        static DatabaseContext x = new DatabaseContext();
        ITamaRepository Tamas = new DBTamaRepository(x);
        HelperFactory ninject = new HelperFactory();
        public int AddTamagotchi(string name)
        {

            Random rnd = new Random();
            DateTime creationDate = Tamas.RepoTime();

            TamaFlags tf = new TamaFlags();
            Tamagotchi tama = new Tamagotchi();
            tama.Name = name;
            tama.CreationData = creationDate;
            tama.LastUpdate = creationDate;
            tama.Flags = tf;
            tama.ActionDone = creationDate;
            tama.ImgId = rnd.Next(1, 13);
            Tamas.create(tama);

            return tama.Id;
        }


        public List<Tamagotchi> GetAllTamagotchi()
        {
            // TODO
            // UPDATE TAMA'S

            List<Tamagotchi> tamas =  Tamas.getList();

            foreach(Tamagotchi t in tamas)
            {
                Tamagotchi x = t;
                ninject.Load(x, false);
                x = ninject.Updater.update(x, Tamas);
                Tamas.update(x);
            }

            return Tamas.getList();
        }

        public Tamagotchi GetTamagotchi(int value)
        {
            if (Tamas.getList().Where(t => t.Id == value).Count() != 0)
            {
                Tamagotchi tama = Tamas.getList().First(t => t.Id == value);

                // Update Tama
                ninject.Load();
                tama = ninject.Updater.update(tama, Tamas);
                Tamas.update(tama);

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
                switch (name)
                {
                    case "Crazy":
                        tama.Flags.Crazy = !tama.Flags.Crazy;
                        Tamas.update(tama);
                        return true;
                    case "Honger":
                        tama.Flags.Honger = !tama.Flags.Honger;
                        Tamas.update(tama);
                        return true;
                    case "Isolatie":
                        tama.Flags.Isolatie = !tama.Flags.Isolatie;
                        Tamas.update(tama);
                        return true;
                    case "Munchies":
                        tama.Flags.Munchies = !tama.Flags.Munchies;
                        Tamas.update(tama);
                        return true;
                    case "Slaaptekort":
                        tama.Flags.Slaaptekort = !tama.Flags.Slaaptekort;
                        Tamas.update(tama);
                        return true;
                    case "Topatleet":
                        tama.Flags.Topatleet = !tama.Flags.Topatleet;
                        Tamas.update(tama);
                        return true;
                    case "Vermoeidheid":
                        tama.Flags.Vermoeidheid = !tama.Flags.Vermoeidheid;
                        Tamas.update(tama);
                        return true;
                    case "Verveling":
                        tama.Flags.Verveling = !tama.Flags.Verveling;
                        Tamas.update(tama);
                        return true;
                    case "Voedseltekort":
                        tama.Flags.Voedseltekort = !tama.Flags.Voedseltekort;
                        Tamas.update(tama);
                        return true;
                };

                return false;

            }
        

        // Only used in TestService
        public bool UpdateTamagochi(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            ninject.Load(tama, false);
            tama = ninject.Updater.update(tama, Tamas);
            Tamas.update(tama);

            return false;
        }

        public bool Eat(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            DateTime time;
            if (canExecute(tama, out time))
            {

                ninject.Load(tama, true);
                tama = ninject.Updater.update(tama, Tamas);
                Tamas.update(tama);

                if (!canExecute(tama, out time))
                    return false;


                tama.Hunger = 0;
                time = time.AddSeconds(30);
                tama.ActionDone = time;
                Tamas.update(tama);
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
                ninject.Load(tama, true);
                tama = ninject.Updater.update(tama, Tamas);
                Tamas.update(tama);

                if (!canExecute(tama, out time))
                    return false;

                tama.Sleep = 0;
                time = time.AddHours(2);
                tama.ActionDone = time;
                Tamas.update(tama);
                return true;
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
                ninject.Load(tama, true);
                tama = ninject.Updater.update(tama, Tamas);
                Tamas.update(tama);

                if (!canExecute(tama, out time))
                    return false;

                tama.Boredom -= 10;
                if (tama.Boredom < 0)
                    tama.Boredom = 0;

                time = time.AddSeconds(30);
                tama.ActionDone = time;
                Tamas.update(tama);
                return true;
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
                ninject.Load(tama, true);
                tama = ninject.Updater.update(tama, Tamas);
                Tamas.update(tama);

                if (!canExecute(tama, out time))
                    return false;

                tama.Health -= 5;
                if (tama.Health < 0)
                    tama.Health = 0;

                time = time.AddMinutes(1);
                tama.ActionDone = time;
                Tamas.update(tama);
                return true;
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
                ninject.Load(tama, true);
                tama = ninject.Updater.update(tama, Tamas);
                Tamas.update(tama);

                if (!canExecute(tama, out time))
                    return false;
   

                tama.Health -= 10;
                if (tama.Health < 0)
                    tama.Health = 0;

                time = time.AddMinutes(1);
                tama.ActionDone = time;
                Tamas.update(tama);
                return true;
            }
            return false;
        }

        private bool canExecute(Tamagotchi tama, out DateTime time)
        {
            time = Tamas.RepoTime();
            if (tama == null || tama.isDead)
                return false;

            return (DateTime.Compare(time, tama.ActionDone) >= 0);
        }

        public string GetStatus(int tamaID)
        {
            Tamagotchi tama = GetTamagotchi(tamaID);
            if (tama.isDead)
                return "Dead";

            int[] list = new int[4];

            list[0] = tama.Health;
            list[1] = tama.Hunger;
            list[2] = tama.Boredom;
            list[3] = tama.Sleep;
            int maxValue = list.Max();

            if (maxValue < 20)
                return "Happy";

            int maxIndex = list.ToList().IndexOf(maxValue);

            switch (maxIndex)
            {
                case 0:
                    return "Sick";
                case 1:
                    return "Hungry";
                case 2:
                    return "Bored";
                case 3:
                    return "Sleeping";
                default:
                    return "Happy";
            }
        }
    }
}
