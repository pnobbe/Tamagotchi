using System;
using System.Collections.Generic;
using TamaConsole.TamaService;
using System.Linq;

namespace TamaConsole
{
    class Program
    {
        private static Tamagotchi tama;
        private static TamaLogicClient service = new TamaLogicClient();


        static void Main(string[] args)
        {

            while (true)
            {
                Init();
                ListTamas();
                run();
            }

        }


        private static void Init()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~     Tamagochi!     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  Marius & Patrick  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Druk op een toets om te beginnen");
            Console.ReadKey();
            
        }

        private static void ListTamas()
        {
            char c = 's';
            do
            {
                Console.Clear();
                Console.WriteLine("druk op 'A' voor alle Tamagochi's, \nop 'L' voor alle levende tamagochi's. \n'N' voor een nieuwe Tamagothi \n('S' = stop)");
                ConsoleKeyInfo cki = Console.ReadKey();
                c = cki.KeyChar;

            } while (c != 'a' && c != 'l' && c != 's' && c != 'n');

            Console.Clear();
            Console.WriteLine("Please wait..");

            Tamagotchi[] x = service.GetAllTamagotchi();

            List<Tamagotchi> list = new List<Tamagotchi>(x);


            switch(c)
            {
                case 'n':
                    tama = newTama();
                    break;
                case 's':
                    Environment.Exit(0);
                    break;
                case 'l':
                    list = list.Where(s => !s.isDead).ToList();
                    goto case 'a';
                case 'a':
                     Console.Clear();

                    Console.WriteLine("[ID]      [NAME]      [CREATIONDATE]");
                    foreach(Tamagotchi t in list)
                    {
                        Console.WriteLine("[" + t.Id + "]      ["+ t.Name +"]      ["+ t.CreationData + "]");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    tama = getTama();
                    break;
            }
           
        }

        private static Tamagotchi getTama()
        {
            int i = 0;
            Tamagotchi t = null;

            bool found = false;
            do
            {
                Console.Write("Jouw tamagochi ID: ");
                String inp = Console.ReadLine();
                found = int.TryParse(inp, out i);

                if(found)
                {
                    t = service.GetTamagotchi(i);
                    if(t == null)
                    {
                        Console.WriteLine("Tamagotchi bestaat niet.");
                        found = false;
                    }
                }

            } while (!found);

            return t;

        }

        private static Tamagotchi newTama()
        {
            
            Tamagotchi t = null;
            bool found = false;
            do
            {
                Console.Write("Nieuwe tamagochi naam: ");
                String inp = Console.ReadLine();
                found = true;

                if(String.IsNullOrWhiteSpace(inp) || inp.Length > 20)
                {
                    Console.WriteLine("Naam mag uit maximaal 20 characters bestaan & niet uit alleen whitespace");
                    found = false;
                }

                if (found)
                {
                    int i = service.AddTamagotchi(inp);

                    t = service.GetTamagotchi(i);
                }

            } while (!found);

            return t;

        }

        private static void run()
        {
            int i = 0;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("[" + tama.Id + "]      [" + tama.Name + "]      [" + tama.CreationData + "]");
                Console.WriteLine();
                Console.WriteLine("status: " + service.GetStatus(tama.Id));
                Console.WriteLine();
                Console.WriteLine("Gezondheid	    " + tama.Health);
                Console.WriteLine("Honger   	    " + tama.Hunger);
                Console.WriteLine("Vermoeidheid	    " + tama.Sleep);
                Console.WriteLine("Verveeldheid	    " + tama.Boredom);
                Console.WriteLine();

                if(service.GetStatus(tama.Id).Equals("Dead"))
                {
                    Console.WriteLine("Je kan geen acties uitvoeren op een dode Tamagotchi.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    if(i != 0)
                    {
                        Console.WriteLine("Je moet " + i + "Seconden wachten voordat je een actie kan uitvoeren");
                    }
                    i = 0;
                    bool done;
                    if(!doAction(out done))
                    {
                        i = service.SecTillAction(tama.Id);
                    }

                    if (done)
                        break;
                }

                tama = service.GetTamagotchi(tama.Id);

            }
        }

        private static bool doAction(out bool done)
        {
            bool found = false;
            done = false;
            do
            {
                Console.Write("Actions: Eat, Sleep, Play, Workout, Hug, Stop: ");
                String inp = Console.ReadLine();
                found = true;
                inp = inp.ToLower();
                switch(inp)
                {
                    case "eat":
                        return service.Eat(tama.Id);
                    case "sleep":
                        return service.Sleep(tama.Id);;
                    case "play":
                        return service.Play(tama.Id);;
                    case "workout":
                        return service.Workout(tama.Id);;
                    case "hug":
                        return service.Hug(tama.Id);;
                    case "stop":
                        done = true;
                        return true;
                    default:
                        found = false;
                        break;

                }

            } while (!found);

            return false;
        }
    }
}
