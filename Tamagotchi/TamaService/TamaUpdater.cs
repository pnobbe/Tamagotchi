using System;
using System.Collections.Generic;
using TamaService.Domain.Interfaces;
using TamaService.Domain.Models;

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

            if (!tama.isDead)
            {
                // use rules
                foreach (ISpelRegel s in _rules)
                {
                    tama = s.ExecuteSpelregel(tama);
                    rp.update(tama);
                }
            }
            tama.LastUpdate = curr;
            rp.update(tama);
            return tama;
        }
    }
}