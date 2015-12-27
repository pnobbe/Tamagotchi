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

        public HelperFactory()
        {
            lst = new List<ISpelRegel>();
            lst.Add(new None());

        }
        public override void Load()
        {
            this.Rebind<List<ISpelRegel>>().ToConstant(lst);
        }

        public void Load(Tamagotchi t, Boolean OnAction)
        {
            lst = new List<ISpelRegel>();

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

            
             
        }
        public TamaUpdater Updater
        {
            get
            {
                IKernel kernel = new StandardKernel(this);
                var context = kernel.Get<List<ISpelRegel>>();

                return new TamaUpdater(lst);
            }
        }
    }
}