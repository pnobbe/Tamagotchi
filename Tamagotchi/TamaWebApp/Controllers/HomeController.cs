using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamaWebApp.TamaService;

namespace TamaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public TamaLogicClient service = new TamaLogicClient();
        List<Tamagotchi> list = new List<Tamagotchi>();

        public ActionResult Index()
        {
            return View(service.GetAllTamagotchi().OrderByDescending(t => t.Id).AsEnumerable());
        }

        [HttpGet, ActionName("Tamagotchi")]
        public ActionResult Tamagotchi([Bind(Include = "Id")] Tamagotchi t)
        {
            return View(service.GetTamagotchi(t.Id));
        }

        [HttpGet, ActionName("Eat")]
        public ActionResult Eat([Bind(Include = "Id")] Tamagotchi t)
        {
            if (ModelState.IsValid)
            {
                service.Eat(t.Id);
            }
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

    }
}