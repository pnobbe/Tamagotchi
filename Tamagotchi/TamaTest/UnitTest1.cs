using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TamaService;

namespace TamaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddAndGet()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();

            service.AddTamagotchi("Darth Sidious");
            Assert.AreEqual(service.GetAllTamagotchi().Count, 1);
            Tamagotchi t = service.GetAllTamagotchi()[0];
            Assert.AreEqual(t.Name, "Darth Sidious");

            Tamagotchi t2 = service.GetTamagotchi(1);

            Assert.AreEqual(t, t2);
        }


        [TestMethod]
        public void TestFlipFlag()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();

            service.AddTamagotchi("Darth Sidious");
            
            TamaFlags tf = new TamaFlags();
            tf.Crazy = true;
            tf.Honger = true;
            tf.Isolatie = true;
            tf.Munchies = true;
            tf.Slaaptekort = true;
            tf.Topatleet = true;
            tf.Vermoeidheid = true;
            tf.Verveling = true;
            tf.Voedseltekort = true;

            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
            service.FlipFlag("Crazy", 1);
            tf.Crazy = !tf.Crazy;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
            service.FlipFlag("Crazy", 1);
            tf.Crazy = !tf.Crazy;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));

            service.FlipFlag("Honger", 1);
            tf.Honger = !tf.Honger;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
            
            service.FlipFlag("Isolatie", 1);
            tf.Isolatie = !tf.Isolatie;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
            
            service.FlipFlag("Munchies", 1);
            tf.Munchies = !tf.Munchies;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
           
            service.FlipFlag("Slaaptekort", 1);
            tf.Slaaptekort = !tf.Slaaptekort;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
           
            service.FlipFlag("Topatleet", 1);
            tf.Topatleet = !tf.Topatleet;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
           
            service.FlipFlag("Vermoeidheid", 1);
            tf.Vermoeidheid = !tf.Vermoeidheid;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
            
            service.FlipFlag("Verveling", 1);
            tf.Verveling = !tf.Verveling;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));
            
            service.FlipFlag("Voedseltekort", 1);
            tf.Voedseltekort = !tf.Voedseltekort;
            Assert.IsTrue(compareFlags(service.GetTamagotchi(1).Flags, tf));



        }

        private bool compareFlags(TamaFlags a, TamaFlags b)
        {
            if(a.Crazy != b.Crazy)
                return false;
            if(a.Honger != b.Honger)
                return false;
            if(a.Isolatie != b.Isolatie)
                return false;
            if(a.Munchies != b.Munchies)
                return false;
            if(a.Slaaptekort != b.Slaaptekort)
                return false;
            if(a.Topatleet != b.Topatleet)
                return false;
            if(a.Vermoeidheid != b.Vermoeidheid)
                return false;
            if(a.Verveling != b.Verveling)
                return false;
            if (a.Voedseltekort != b.Voedseltekort)
                return false;

            return true;
        }
        
        [TestMethod]
        public void TestEat()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");
            
            service.GetTamagotchi(1).Hunger = 30;
            service.Eat(1);
            Assert.AreEqual(service.GetTamagotchi(1).lastAction, "Eat");
            Assert.AreEqual(service.GetTamagotchi(1).Hunger, 0);

            Assert.IsFalse(service.Eat(9001));
        }


        [TestMethod]
        public void TestSleep()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");

            service.GetTamagotchi(1).Sleep = 30;
            Assert.IsTrue(service.Sleep(1));
            Assert.AreEqual(service.GetTamagotchi(1).lastAction, "Sleep");
            Assert.AreEqual(service.GetTamagotchi(1).Sleep, 0);

            Assert.IsFalse(service.Sleep(9001));
        }


        [TestMethod]
        public void TestWorkout()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");

            service.GetTamagotchi(1).Health = 3;
            Assert.IsTrue(service.Workout(1));
            Assert.AreEqual(service.GetTamagotchi(1).lastAction, "Workout");
            Assert.AreEqual(service.GetTamagotchi(1).Health, 0);

            Assert.IsFalse(service.Workout(9001));
        }


        [TestMethod]
        public void TestHug()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");

            service.GetTamagotchi(1).Health = 8;
            Assert.IsTrue(service.Hug(1));
            Assert.AreEqual(service.GetTamagotchi(1).lastAction, "Hug");
            Assert.AreEqual(service.GetTamagotchi(1).Health, 0);

            Assert.IsFalse(service.Hug(9001));
        }


        [TestMethod]
        public void TestPlay()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");

            service.GetTamagotchi(1).Boredom = 8;
            Assert.IsTrue(service.Play(1));
            Assert.AreEqual(service.GetTamagotchi(1).lastAction, "Play");
            Assert.AreEqual(service.GetTamagotchi(1).Boredom, 0);

            Assert.IsFalse(service.Play(9001));
        }

        [TestMethod]
        public void TestGetStatus()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");
            service.GetTamagotchi(1).isDead = true;
            Assert.AreEqual(service.GetStatus(1), "Dead");

            service.GetTamagotchi(1).isDead = false;
            Assert.AreEqual(service.GetStatus(1), "Happy");

            service.GetTamagotchi(1).Boredom = 25;
            Assert.AreEqual(service.GetStatus(1), "Bored");


            service.GetTamagotchi(1).Boredom = 10;
            service.GetTamagotchi(1).Health = 25;
            Assert.AreEqual(service.GetStatus(1), "Sick");

            service.GetTamagotchi(1).Health = 10;
            service.GetTamagotchi(1).Sleep = 25;
            Assert.AreEqual(service.GetStatus(1), "Sleepy");


            service.GetTamagotchi(1).Sleep = 10;
            service.GetTamagotchi(1).Hunger = 25;
            Assert.AreEqual(service.GetStatus(1), "Hungry");
        }

        [TestMethod]
        public void TestSecTillAction()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");

            Assert.IsFalse(service.SecTillAction(1) > 0);
            service.GetTamagotchi(1).Sleep = 30;
            Assert.IsTrue(service.Sleep(1));
            Assert.IsTrue(service.SecTillAction(1) > 0);
            Assert.IsFalse(service.Sleep(1));
        }

         [TestMethod]
        public void TestUpdate()
        {
            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");
            Tamagotchi i = service.GetTamagotchi(1);

            i.CreationData = service.Tamas.RepoTime().AddHours(-1);
            i.LastUpdate = service.Tamas.RepoTime().AddHours(-1);
            service.UpdateTamagochi(1);

            Assert.IsTrue(service.GetTamagotchi(1).Hunger != 0);
            Assert.IsTrue(service.GetTamagotchi(1).Boredom != 0);
            Assert.IsTrue(service.GetTamagotchi(1).Health != 0);
            Assert.IsTrue(service.GetTamagotchi(1).Sleep != 0);
        }

        [TestMethod]
        public void CrazyAndIsolationCapTest()
         {
             TamaService.TamaService service = new TamaService.TamaService();
             service.Tamas = new TestTamaRepo();
             service.AddTamagotchi("Darth Sidious");

             // crazy & Isolatie cap
             while (!service.GetTamagotchi(1).isDead)
             {
                Tamagotchi i = service.GetTamagotchi(1);
                i.Hunger = 0;
                i.Boredom = 0;
                i.Health = 100;
                i.Sleep = 0;
                i.CreationData = service.Tamas.RepoTime().AddHours(-1);
                i.LastUpdate = service.Tamas.RepoTime().AddHours(-1);
                i.ActionDone = service.Tamas.RepoTime().AddHours(-1);
                service.Eat(1);
                Assert.AreEqual(service.GetTamagotchi(1).Health, 100);

                 // Infinite loop = fail.
             }
            
         }
        [TestMethod]
        public void VoedseltekortAndHungerCapTest()
        {

            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");
            Tamagotchi i = service.GetTamagotchi(1);
            // voedseltekort & honger cap test
            i.Hunger = 100;
            i.Boredom = 0;
            i.Health = 20;
            i.Sleep = 0;
            i.CreationData = service.Tamas.RepoTime().AddHours(-1);
            i.LastUpdate = service.Tamas.RepoTime().AddHours(-1);
            service.UpdateTamagochi(1);
            Assert.AreEqual(service.GetTamagotchi(1).Hunger, 100);
            Assert.IsTrue(service.GetTamagotchi(1).isDead);

        }

        [TestMethod]
        public void MunchiesAndHungerCapTest()
        {

            TamaService.TamaService service = new TamaService.TamaService();
            service.Tamas = new TestTamaRepo();
            service.AddTamagotchi("Darth Sidious");
            Tamagotchi i = service.GetTamagotchi(1);
            
            // voedseltekort & honger cap test
            i.Hunger = 94;
            i.Boredom = 100;
            i.Health = 20;
            i.Sleep = 0;

            i.CreationData = service.Tamas.RepoTime().AddHours(-1);
            i.LastUpdate = service.Tamas.RepoTime().AddHours(-1);
            service.UpdateTamagochi(1);
            Assert.AreEqual(service.GetTamagotchi(1).Hunger, 100);
            Assert.IsTrue(service.GetTamagotchi(1).isDead);

        }

        [TestMethod]
        public void SlaaptekortAndVermoeidheidCapTest()
         {
             TamaService.TamaService service = new TamaService.TamaService();
             service.Tamas = new TestTamaRepo();
             service.AddTamagotchi("Darth Sidious");

             Tamagotchi i = service.GetTamagotchi(1);
            // slaaptekort & vermoeidheid cap
            i.Hunger = 0;
            i.Boredom = 0;
            i.Health = 20;
            i.Sleep = 100;
            i.CreationData = service.Tamas.RepoTime().AddHours(-1);
            i.LastUpdate = service.Tamas.RepoTime().AddHours(-1);
            service.UpdateTamagochi(1);
            Assert.AreEqual(service.GetTamagotchi(1).Sleep, 100);
            Assert.IsTrue(service.GetTamagotchi(1).isDead);
            service.GetTamagotchi(1).isDead = false;

         }
    }
}
