using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamaWebApp.Models;

namespace TamaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public TamaService.TamaLogicClient service = new TamaService.TamaLogicClient();
        List<Tamagotchi> list = new List<Tamagotchi>();

        public ActionResult Index()
        {
            list = new List<Tamagotchi>();
            foreach (var item in service.GetAllTamagotchi())
            {
                list.Add(new Tamagotchi() { Id = item.Id, Boredom = item.Boredom, CreationData = item.CreationData, Health = item.Health, Hunger = item.Hunger, isDead = item.isDead, LastUpdate = item.LastUpdate, Name = item.Name, Sleep = item.Sleep/*, Spelregels = new TamaFlags() { Crazy = item.Spelregels.Crazy, Honger = item.Spelregels.Honger, Isolatie = item.Spelregels.Isolatie, Munchies = item.Spelregels.Munchies, Slaaptekort = item.Spelregels.Slaaptekort, TamaId = item.Id, Topatleet = item.Spelregels.Topatleet, Vermoeidheid = item.Spelregels.Vermoeidheid, Verveling = item.Spelregels.Verveling, Voedseltekort = item.Spelregels.Voedseltekort }*/ });
            }
            return View(list.AsEnumerable());
        }

        [HttpPost, ActionName("Tamagotchi")]
        [ValidateAntiForgeryToken]
        public ActionResult Tamagotchi([Bind(Include = "Id")] Tamagotchi t)
        {
            Console.WriteLine(t.Id + " " + t.Name);
            return View(list.Find(x => x.Id == t.Id));
        }
    }
}