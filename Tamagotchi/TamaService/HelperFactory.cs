using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamaService.Domain.Interfaces;
using TamaService.Domain.Models;

namespace TamaService
{
    public class HelperFactory : NinjectModule
    {
        List<ISpelRegel> lst;

        public override void Load()
        {

            lst = new List<ISpelRegel>();
            lst.Add(new None());

           // this.Bind<List<ISpelRegel>>().ToConstant(lst);
            
        }

        public void Load(Tamagotchi t, Boolean OnAction)
        {
            lst = new List<ISpelRegel>();
            lst.Add(new None());

            if (OnAction)
            {
                if (t.Flags.Crazy)
                    lst.Add(new Crazy());
            }
            // Status Changers
            if (t.Flags.Honger)
                lst.Add(new Honger());
            if (t.Flags.Isolatie)
                lst.Add(new Isolatie());
            if (t.Flags.Munchies)
                lst.Add(new Munchies());
            if (t.Flags.Vermoeidheid)
                lst.Add(new Vermoeidheid());
            if (t.Flags.Verveling)
                lst.Add(new Verveling());

            // Can die
            if (t.Flags.Slaaptekort)
                lst.Add(new Slaaptekort());
            if (t.Flags.Voedseltekort)
                lst.Add(new Voedseltekort());
            if (t.Flags.Topatleet)
                lst.Add(new Topatleet());

            
            
            
            //this.Bind<List<ISpelRegel>>().ToConstant(lst);
        }
        public TamaUpdater Updater
        {
            get
            {
                //IKernel kernel = new StandardKernel(this);
                //var context = kernel.Get<List<ISpelRegel>>();

                lst = new List<ISpelRegel>();
                lst.Add(new None());

                return new TamaUpdater(lst);
            }
        }
    }
}