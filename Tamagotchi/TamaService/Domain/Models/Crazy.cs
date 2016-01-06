using System;
using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Crazy : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            if(t.Health >= 100)
            {
                if (new Random().Next(0, 2) == 0)
                    t.isDead = true;
            }
            return t;
        }
    }
}