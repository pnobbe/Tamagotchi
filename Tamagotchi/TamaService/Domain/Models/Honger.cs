using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Honger : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            t.Hunger += (short)(t.HoursPassed * 5);
            if (t.Hunger > 100 || t.Hunger < 0)
            {
                t.Hunger = 100;
            }
            return t;
        }
    }
}