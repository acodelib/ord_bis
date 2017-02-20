using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BISystem.ORM;

namespace BISystem.Controllers
{
    public class DbTypeController : Controller
    {
        private _DbModel db = new _DbModel();

        //
        // GET: /DbType/

        public ActionResult Index()
        {
            return View(db.Db_Types.ToList());
        }

        //
        // GET: /DbType/Details/5

        public ActionResult Details(int id = 0)
        {
            Db_Type db_type = db.Db_Types.Find(id);
            if (db_type == null)
            {
                return HttpNotFound();
            }
            return View(db_type);
        }

        //
        // GET: /DbType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DbType/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Db_Type db_type)
        {
            if (ModelState.IsValid)
            {
                db.Db_Types.Add(db_type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(db_type);
        }

        //
        // GET: /DbType/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Db_Type db_type = db.Db_Types.Find(id);
            if (db_type == null)
            {
                return HttpNotFound();
            }
            return View(db_type);
        }

        //
        // POST: /DbType/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Db_Type db_type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(db_type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(db_type);
        }

        //
        // GET: /DbType/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Db_Type db_type = db.Db_Types.Find(id);
            if (db_type == null)
            {
                return HttpNotFound();
            }
            return View(db_type);
        }

        //
        // POST: /DbType/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Db_Type db_type = db.Db_Types.Find(id);
            db.Db_Types.Remove(db_type);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}