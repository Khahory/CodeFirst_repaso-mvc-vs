using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst_repaso2.Models;
using System.Data.Entity;

namespace Codefirst_repaso2.Controllers
{
    public class MiembroController : Controller
    {
        private AdoContext db;
        public MiembroController()
        {
            db = new AdoContext();
        }
        // GET: Miembro
        public ActionResult Index()
        {
            var model = db.MiembrosSet.Include(x => x.Familia).ToList();
            return View(model);
        }

        // GET: Miembro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Miembro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Miembro/Create
        [HttpPost]
        public ActionResult Create(Miembro model)
        {
            try
            {
                // TODO: Add insert logic here
                db.MiembrosSet.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Miembro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Miembro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Miembro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Miembro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
