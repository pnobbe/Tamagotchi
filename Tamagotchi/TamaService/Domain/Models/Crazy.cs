using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Crazy : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            if(t.Health >= 100)
            {
                if (new Random().Next(1, 100) % 2 == 1)
                    t.isDead = true;
            }
            return t;
        }
    }
}