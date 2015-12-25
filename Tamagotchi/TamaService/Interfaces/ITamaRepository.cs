using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamaService
{
    public interface ITamaRepository
    {
        //Create
        void create(Tamagotchi newTama);

        // Read
        List<Tamagotchi> getList();
        
        // Update
        bool update(Tamagotchi tama);

        // GetTime
        DateTime RepoTime();
    }
}
