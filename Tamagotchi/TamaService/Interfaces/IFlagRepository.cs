using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamaService
{
    public interface IFlagRepository
    {
        //Create
        void create(TamaFlags newTama);

        // Read
        List<TamaFlags> getList();

        // Update
        bool update(TamaFlags tama);
    }
}
