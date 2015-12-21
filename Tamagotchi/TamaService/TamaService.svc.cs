using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TamaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TamaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TamaService.svc or TamaService.svc.cs at the Solution Explorer and start debugging.
    public class TamaService : ITamaLogic
    {

        private Database x = new Database();
        public void AddTamagotchi(string name)
        {
            var dQuery = x.Database.SqlQuery<DateTime>("SELECT GETDATE() ");
            DateTime dbDate = dQuery.AsEnumerable().First();
            TamaFlags tf = new TamaFlags();
            x.Tamagotchis.Add(new Tamagotchi() { Name = name, CreationData = dbDate, LastUpdate = dbDate, Spelregels = tf });
            x.SaveChanges();
        }

        public string GetTamagotchi(int value)
        {
            if (x.Tamagotchis.Where(t => t.Id == value).Count() != 0)
            {
                return x.Tamagotchis.First(t => t.Id == value).Id + "";
            }
            else
            {
                return "Tamagotchi met Id " + value + " is niet gevonden!";
            }
        }

    }
}
