using System;
using System.Collections.Generic;
using TamaService.Domain.Models;

namespace TamaService.Domain.Interfaces
{
    public interface ITamaRepository
    {
        //Create
        Tamagotchi create(Tamagotchi newTama);

        // Read
        List<Tamagotchi> getList();

        // Update
        bool update(Tamagotchi tama);

        // GetTime
        DateTime RepoTime();
    }
}
