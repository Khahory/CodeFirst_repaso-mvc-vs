using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst_repaso1.Models;
using System.Data.Entity;

namespace Codefirst_repaso1.Controllers
{
    public class MascotaController : Controller
    {
        private AdoDbContext db;
        public MascotaController()
        {
            db = new AdoDbContext();
        }
        // GET: Mascota
        public ActionResult Index()
        {
            var model = db.Mascotas.Include(x => x.Domadors).ToList();
            return View(model);
        }

        // GET: Mascota/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mascota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mascota/Create
        [HttpPost]
        public ActionResult Create(Mascota model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Mascotas.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mascota/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mascota/Edit/5
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

        // GET: Mascota/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mascota/Delete/5
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
