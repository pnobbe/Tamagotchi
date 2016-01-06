using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Munchies : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
           if(t.Flags.Honger)
           {
               if (t.Boredom > 80)
               {
                   Honger h = new Honger();
                   return h.ExecuteSpelregel(t);
               }
           }
           return t;
        }
    }
}