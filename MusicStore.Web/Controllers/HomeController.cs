using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Web.AlbumService;

namespace MusicStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private IAlbumService albumService;

        public HomeController(IAlbumService albumService)
        {
            this.albumService = albumService;
        }
        
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var albums = albumService.GetAll();
            return View();
        }

    }
}
