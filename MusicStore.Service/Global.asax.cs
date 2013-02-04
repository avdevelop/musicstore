using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Ninject;
using AutoMapper;
using MusicStore.Models;
using MusicStore.DTO;
using Ninject.Web.Common;

namespace MusicStore.Service
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            Mapper.CreateMap<Artist, ArtistDTO>();            
            Mapper.CreateMap<Album, AlbumDTO>();

            Mapper.AssertConfigurationIsValid();
                        
            StandardKernel kernel = new StandardKernel(new WCFNinject());
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            return kernel;
        }

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}