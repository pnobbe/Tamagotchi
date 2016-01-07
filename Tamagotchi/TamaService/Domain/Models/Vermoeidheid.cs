using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class Vermoeidheid : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {

            t.Sleep += (short)(t.HoursPassed * 5);
            if (t.Sleep > 100 | t.Sleep < 0)
            {
                t.Sleep = 100;
            }
            return t;
        }
    }
}