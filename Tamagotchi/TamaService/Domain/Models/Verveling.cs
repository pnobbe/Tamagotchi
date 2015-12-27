using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Verveling : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            t.Boredom += (short)(t.HoursPassed * 15);
            if (t.Boredom > 100 | t.Boredom < 0)
            {
                t.Boredom = 100;
            }
            return t;
        }
    }
}