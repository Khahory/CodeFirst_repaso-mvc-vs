using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst_repaso1.Models;

namespace Codefirst_repaso1.Controllers
{
    public class DomadorController : Controller
    {
        private AdoDbContext db;
        public DomadorController()
        {
            db = new AdoDbContext();
        }
        // GET: Domador
        public ActionResult Index()
        {
            var model = db.Domadores.ToList();
            return View(model);
        }

        // GET: Domador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Domador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Domador/Create
        [HttpPost]
        public ActionResult Create(Domador model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Domadores.Add(model);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Domador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Domador/Edit/5
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

        // GET: Domador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Domador/Delete/5
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
