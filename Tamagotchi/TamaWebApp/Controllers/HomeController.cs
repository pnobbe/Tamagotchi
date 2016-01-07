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
        List<Tamagotchi> list = new List<Tamagotchi>();

        public ActionResult Index()
        {
            TamaLogicClient service = new TamaLogicClient();
            var value = service.GetAllTamagotchi().OrderByDescending(t => t.Id).AsEnumerable();
            service.Close();
            return View(value);
        }

        [HttpGet, ActionName("Tamagotchi")]
        public ActionResult Tamagotchi([Bind(Include = "Id")] Tamagotchi t)
        {
            TamaLogicClient service = new TamaLogicClient();
            var value = service.GetTamagotchi(t.Id);
            service.Close();
            if (value != null)
            {
                return View(value);
            }
            return RedirectToAction("Index");
        }

    }
}