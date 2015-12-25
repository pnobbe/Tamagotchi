using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
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

        [HttpGet, ActionName("Sleep")]
        public ActionResult Sleep([Bind(Include = "Id")] Tamagotchi t)
        {
            if (ModelState.IsValid)
            {
                service.Sleep(t.Id);
            }
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

        [HttpGet, ActionName("Hug")]
        public ActionResult Hug([Bind(Include = "Id")] Tamagotchi t)
        {
            if (ModelState.IsValid)
            {
                service.Hug(t.Id);
            }
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

        [WebMethod]
        public string FlipFlag(int id, string flag)
        {
            if (ModelState.IsValid)
            {
                if (service.FlipFlag(flag, id))
                {
                    return "{ \"status\": \"Correct\" }";
                }
            }
            return "{ \"status\": \"Error\" }";
        }
    }

}