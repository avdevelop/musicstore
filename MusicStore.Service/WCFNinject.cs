using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using MusicStore.Repository;
using MusicStore.Models;

namespace MusicStore.Service
{
    public class WCFNinject : NinjectModule
    {
        public override void Load()
        {
            //Injects the constructors of all DI-ed objects 
            //with a LinqToSQL implementation of IRepository
            Bind<IRepository<Artist>>().To<NHibernateRepository<Artist>>();
            Bind<IRepository<Album>>().To<NHibernateRepository<Album>>();
        }
    }
}
