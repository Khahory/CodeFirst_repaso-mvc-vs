using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst_repaso2.Models;
using System.Data.Entity;

namespace Codefirst_repaso2.Controllers
{
    public class FamiliaController : Controller
    {
        private AdoContext db;
        public FamiliaController()
        {
            db = new AdoContext();   
        }
        // GET: Familia
        public ActionResult Index()
        {
            var model = db.FamiliasSet.ToList();
            return View(model);
        }

        // GET: Familia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Familia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Familia/Create
        [HttpPost]
        public ActionResult Create(Familia model)
        {
            try
            {
                // TODO: Add insert logic here
                db.FamiliasSet.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Familia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Familia/Edit/5
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

        // GET: Familia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Familia/Delete/5
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
