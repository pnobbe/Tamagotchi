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
        IFlagRepository Flags = new DBFlagRepository(x);

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

            return Tamas.getList();
        }

        public Tamagotchi GetTamagotchi(int value)
        {
            if (Tamas.getList().Where(t => t.Id == value).Count() != 0)
            {
                Tamagotchi tama = Tamas.getList().First(t => t.Id == value);

                // TODO
                // Update Tama


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

                TamaFlags flags = tama.Flags;

                switch (name)
                {
                    case "Crazy":
                        flags.Crazy = !flags.Crazy;
                        Flags.update(flags);
                        return true;
                    case "Honger":
                        flags.Honger = !flags.Honger;
                        Flags.update(flags);
                        return true;
                    case "Isolatie":
                        flags.Isolatie = !flags.Isolatie;
                        Flags.update(flags);
                        return true;
                    case "Munchies":
                        flags.Munchies = !flags.Munchies;
                        Flags.update(flags);
                        return true;
                    case "Slaaptekort":
                        flags.Slaaptekort = !flags.Slaaptekort;
                        Flags.update(flags);
                        return true;
                    case "Topatleet":
                        flags.Topatleet = !flags.Topatleet;
                        Flags.update(flags);
                        return true;
                    case "Vermoeidheid":
                        flags.Vermoeidheid = !flags.Vermoeidheid;
                        Flags.update(flags);
                        return true;
                    case "Verveling":
                        flags.Verveling = !flags.Verveling;
                        Flags.update(flags);
                        return true;
                    case "Voedseltekort":
                        flags.Voedseltekort = !flags.Voedseltekort;
                        Flags.update(flags);
                        return true;
                };

                return false;

            }
        

        public bool UpdateTamagochi(int value)
        {
            Tamagotchi tama = GetTamagotchi(value);

            if (tama == null)
                return false;

            List<ISpelRegel> x = new List<ISpelRegel>();

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

            int i = DateTime.Compare(time, tama.ActionDone);
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
