using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamaService.Domain.Interfaces
{
    public interface ISpelRegel
    {
        Tamagotchi ExecuteSpelregel(Tamagotchi t);
    }
}
