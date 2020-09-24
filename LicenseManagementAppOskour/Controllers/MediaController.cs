using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LMAO;
using LicenseManagementAppOskour.Models;

namespace LicenseManagementAppOskour.Controllers
{
    public class MediaController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Media
        public ActionResult Index()
        {
            return View(db.Media.ToList());
        }

        // GET: Media/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Media.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // GET: Media/Create
        public ActionResult CreateFilm()
        {
            ViewData["Licenses"] = db.Licenses.ToList();
            return View();
        }

        // POST: Media/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFilm(Film media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Media.Add(media);
                AddMediaToLicense(media, Convert.ToInt32(LicenseId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // GET: Media/Create
        public ActionResult CreateBook()
        {
            ViewData["Licenses"] = db.Licenses.ToList();
            return View();
        }

        // POST: Media/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBook(Book media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Media.Add(media);
                AddMediaToLicense(media, Convert.ToInt32(LicenseId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // GET: Media/Create
        public ActionResult CreateGame()
        {
            ViewData["Licenses"] = db.Licenses.ToList();
            return View();
        }

        // POST: Media/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateGame(Game media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Media.Add(media);
                AddMediaToLicense(media, Convert.ToInt32(LicenseId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // GET: Media/Create
        public ActionResult CreateMusic()
        {
            ViewData["Licenses"] = db.Licenses.ToList();
            return View();
        }

        // POST: Media/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMusic(Music media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Media.Add(media);
                AddMediaToLicense(media, Convert.ToInt32(LicenseId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // GET: Media/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Media.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            License l = new License();
            foreach (var license in db.Licenses.ToList())
            {
                Media md = license.Medias?.FirstOrDefault(m => m.Id == media.Id);
                if(md != null)
                {
                    l = license;
                }
            }
            ViewData["SelectedLicense"] = l;
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // POST: Media/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMusic(Music media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Entry(media).State = EntityState.Modified;
                EditMediaToLicense(media, Convert.ToInt32(LicenseId));

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // POST: Media/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditFilm(Film media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Entry(media).State = EntityState.Modified;
                EditMediaToLicense(media, Convert.ToInt32(LicenseId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // POST: Media/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(Book media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Entry(media).State = EntityState.Modified;
                EditMediaToLicense(media, Convert.ToInt32(LicenseId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // POST: Media/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditGame(Game media, string LicenseId)
        {
            if (ModelState.IsValid)
            {
                db.Entry(media).State = EntityState.Modified;
                EditMediaToLicense(media, Convert.ToInt32(LicenseId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Licenses"] = db.Licenses.ToList();
            return View(media);
        }

        // GET: Media/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Media.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // POST: Media/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Media media = db.Media.Find(id);
            db.Media.Remove(media);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private void AddMediaToLicense(Media media, int LicenseId)
        {
            if (db.Licenses.First(l => l.Id == LicenseId).Medias == null)
            {
                db.Licenses.First(l => l.Id == LicenseId).Medias = new List<Media>();
            }
            db.Licenses.First(l => l.Id == LicenseId).Medias.Add(media);
        }

        private void EditMediaToLicense(Media media, int LicenseId)
        {
            foreach (var license in db.Licenses.ToList())
            {
                if (license.Medias != null)
                {
                    if (license.Medias.Any(m => m.Id == media.Id))
                        license.Medias.Remove(media);
                }
            }
            if (db.Licenses.First(l => l.Id == LicenseId).Medias == null)
            {
                db.Licenses.First(l => l.Id == LicenseId).Medias = new List<Media>();
            }
            db.Licenses.First(l => l.Id == LicenseId).Medias.Add(media);
        }
    }
}
