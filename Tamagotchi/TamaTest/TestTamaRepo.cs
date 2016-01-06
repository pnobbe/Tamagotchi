using System;
using System.Collections.Generic;
using TamaService.Domain.Interfaces;
using TamaService.Domain.Models;

namespace TamaTest
{
    class TestTamaRepo : ITamaRepository
    {

        List<Tamagotchi> Tamas = new List<Tamagotchi>();
        public Tamagotchi create(Tamagotchi newTama)
        {
            newTama.Id = Tamas.Count + 1;
            Tamas.Add(newTama);
            return newTama;
        }

        public List<Tamagotchi> getList()
        {
            return Tamas;
        }

        public bool update(Tamagotchi tama)
        {
            return true;
        }

        public DateTime RepoTime()
        {
            return DateTime.Now;
        }
    }
}
