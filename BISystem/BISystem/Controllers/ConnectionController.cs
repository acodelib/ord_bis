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
    [Authorize]
    public class ConnectionController : Controller
    {
        private _DbModel db = new _DbModel();

        //
        // GET: /Connection/

        public ActionResult Index()
        {
            var connections = db.Connections.Include(c => c.Db_Type);
            return View(connections.ToList());
        }

        //
        // GET: /Connection/Details/5

        public ActionResult Details(int id = 0)
        {
            Connection connection = db.Connections.Find(id);
            if (connection == null)
            {
                return HttpNotFound();
            }
            return View(connection);
        }

        //
        // GET: /Connection/Create

        public ActionResult Create()
        {
            ViewBag.db_type_id = new SelectList(db.Db_Types, "db_type_id", "name");
            return View();
        }

        //
        // POST: /Connection/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Connection connection)
        {
            if (ModelState.IsValid)
            {
                connection.connection_string = AppLogic.DbParser.getConnectionFromDetails(connection);
                db.Connections.Add(connection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.db_type_id = new SelectList(db.Db_Types, "db_type_id", "name", connection.db_type_id);
            return View(connection);
        }

        //
        // GET: /Connection/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Connection connection = db.Connections.Find(id);
            if (connection == null)
            {
                return HttpNotFound();
            }
            ViewBag.db_type_id = new SelectList(db.Db_Types, "db_type_id", "name", connection.db_type_id);
            return View(connection);
        }

        //
        // POST: /Connection/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Connection connection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(connection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.db_type_id = new SelectList(db.Db_Types, "db_type_id", "name", connection.db_type_id);
            return View(connection);
        }

        //
        // GET: /Connection/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Connection connection = db.Connections.Find(id);
            if (connection == null)
            {
                return HttpNotFound();
            }
            return View(connection);
        }

        //
        // POST: /Connection/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Connection connection = db.Connections.Find(id);
            db.Connections.Remove(connection);
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