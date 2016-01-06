using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Voedseltekort : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            if (t.Hunger >= 100)
                t.isDead = true;
            return t;
        }
    }
}