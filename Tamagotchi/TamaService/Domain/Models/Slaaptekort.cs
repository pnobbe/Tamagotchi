using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Slaaptekort : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            if (t.Sleep >= 100)
                t.isDead = true;
            return t;
        }
    }
}