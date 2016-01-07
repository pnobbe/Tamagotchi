using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Isolatie : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            t.Health += (short)(t.HoursPassed * 5);
            if (t.Health > 100 || t.Health < 0)
            {
                t.Health = 100;
            }
            return t;
        }
    }
}