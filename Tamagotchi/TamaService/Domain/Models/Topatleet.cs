using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Topatleet : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            if (t.Health < 20)
                t.isDead = false;
            return t;
        }
    }
}