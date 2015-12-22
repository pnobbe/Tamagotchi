using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamaWebApp.TamaService;

namespace TamaWebApp.Controllers
{
    public class TamagotchiController : Controller
    {
        public TamaService.TamaLogicClient service = new TamaService.TamaLogicClient();

        // GET: Tamagotchi
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "Name")] Tamagotchi t)
        {
            int Tamaid = -1;
            if (ModelState.IsValid)
            {
                Tamaid = service.AddTamagotchi(t.Name);
            }
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = Tamaid });
        }

        [HttpPost, ActionName("Eat")]
        [ValidateAntiForgeryToken]
        public ActionResult Eat(Tamagotchi t)
        {
            if (ModelState.IsValid)
            {
                service.Eat(t);
            }
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

    }

}