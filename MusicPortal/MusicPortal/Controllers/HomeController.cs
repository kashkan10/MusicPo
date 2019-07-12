using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicPortal.Models; 

namespace MusicPortal.Controllers
{
    public class HomeController : Controller
    {
        SongContext db = new SongContext();

        [HttpGet]
        public ActionResult Index()
        {
            var songs = db.Songs;
            ViewBag.Songs = songs;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            var songs = db.Songs.Where(a => a.Title.Contains(name) || a.Singer.Contains(name)).ToList();
            if (songs.Count <= 0)
                ViewBag.Text = "Совпадений не найдено";

            ViewBag.Songs = songs;
            return View();
        }

        [HttpGet]
        public ActionResult Song(int id)
        {
            var song = db.Songs.Find(id);
            ViewBag.Song = song;
            return View();
        }
    }
}