using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaService.Domain.Interfaces;

namespace TamaService
{
    public class TamaUpdater
    {
        private List<ISpelRegel> _rules;
        
        public TamaUpdater(List<ISpelRegel> Rules)
        {
            _rules = Rules;
        }
        
        public Tamagotchi update(Tamagotchi tama, ITamaRepository rp)
        {
            // get time passed
            TimeSpan diff = tama.LastUpdate - tama.CreationData;
            int timeUsed = (int)(diff.TotalHours);

            DateTime curr = rp.RepoTime();
            TimeSpan diff2 = curr - tama.CreationData;
            tama.HoursPassed = (int)(diff2.TotalHours) - timeUsed;

            // use rules
            foreach(ISpelRegel s in _rules)
            {
               tama = s.ExecuteSpelregel(tama);
            }
            tama.LastUpdate = curr;
            return tama;
        }
    }
}