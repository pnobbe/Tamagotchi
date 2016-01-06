using System;
using System.Web.Mvc;
using System.Web.Services;
using TamaWebApp.TamaService;

namespace TamaWebApp.Controllers
{
    public class TamagotchiController : Controller
    {
        // GET: Tamagotchi
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Add")]
        public ActionResult Add(string name)
        {
            TamaLogicClient service = new TamaLogicClient();
            int Tamaid = -1;
            Tamaid = service.AddTamagotchi(name);
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = Tamaid });
        }

        [HttpGet, ActionName("Eat")]
        public ActionResult Eat([Bind(Include = "Id")] Tamagotchi t)
        {
            TamaLogicClient service = new TamaLogicClient();
            service.Eat(t.Id);
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

        [HttpGet, ActionName("Sleep")]
        public ActionResult Sleep([Bind(Include = "Id")] Tamagotchi t)
        {
            TamaLogicClient service = new TamaLogicClient();
            service.Sleep(t.Id);
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

        [HttpGet, ActionName("Hug")]
        public ActionResult Hug([Bind(Include = "Id")] Tamagotchi t)
        {
            TamaLogicClient service = new TamaLogicClient();
            service.Hug(t.Id);
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

        [HttpGet, ActionName("Workout")]
        public ActionResult Workout([Bind(Include = "Id")] Tamagotchi t)
        {
            TamaLogicClient service = new TamaLogicClient();
            service.Workout(t.Id);
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

        [HttpGet, ActionName("Play")]
        public ActionResult Play([Bind(Include = "Id")] Tamagotchi t)
        {
            TamaLogicClient service = new TamaLogicClient();
            service.Play(t.Id);
            service.Close();
            return RedirectToAction("Tamagotchi", "Home", new { id = t.Id });
        }

        [WebMethod]
        public string FlipFlag(int id, string flag)
        {
            TamaLogicClient service = new TamaLogicClient();
            if (service.FlipFlag(flag, id))
            {
                return "{ \"status\": \"Correct\" }";
            }
            return "{ \"status\": \"Error\" }";
        }

        [WebMethod]
        public string GetCooldown(int id)
        {
            TamaLogicClient service = new TamaLogicClient();
            var value = service.SecTillAction(id);
            Console.WriteLine(value);
            service.Close();
            return "{ \"status\": \"" + value + "\" }";
        }


    }

}