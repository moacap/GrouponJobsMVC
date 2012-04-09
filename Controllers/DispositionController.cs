using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrouponJobsMVC.Models;
namespace GrouponJobsMVC.Controllers
{
    public class DispositionController : Controller
    {
        //
        // GET: /Disposition/
        JobsContext db = new JobsContext();
        public ActionResult Index()
        {
            return View(db.Disposition.ToList());
        }

        //
        // GET: /Disposition/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Disposition.FirstOrDefault(x => x.DispositionId == id));
        }

        //
        // GET: /Disposition/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Disposition/Create

        [HttpPost]
        public ActionResult Create(Disposition collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.Disposition.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Disposition/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(db.Disposition.FirstOrDefault(x => x.DispositionId == id));
        }

        //
        // POST: /Disposition/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Disposition collection)
        {
            try
            {
                // TODO: Add update logic here
                Disposition obj = db.Disposition.FirstOrDefault(x => x.DispositionId == id);

                obj.Name = collection.Name;

                db.SaveChanges();
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Disposition/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(db.Disposition.FirstOrDefault(x => x.DispositionId == id));
        }

        //
        // POST: /Disposition/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Disposition collection)
        {
            try
            {
                // TODO: Add delete logic here
                Disposition obj = db.Disposition.FirstOrDefault(x => x.DispositionId == id);
                db.Disposition.Remove(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
