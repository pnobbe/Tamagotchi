using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaService.Domain.Interfaces;

namespace TamaService.Domain.Models
{
    public class None : ISpelRegel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi t)
        {
            return t;
        }
    }
}