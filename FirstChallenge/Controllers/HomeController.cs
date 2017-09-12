using FirstChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			List<ComicBook> comics = ComicBookManager.GetComicBooks();
            return View(comics);
        }

		public ActionResult Detail(int id)
		{
			List<ComicBook> comics = ComicBookManager.GetComicBooks();
			ComicBook comic = comics.FirstOrDefault(p => p.ComicBookId == id);
			return View(comic);
		}
    }
}