using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrouponJobsMVC.Models;
namespace GrouponJobsMVC.Controllers
{
    public class RatingController : Controller
    {
        //
        // GET: /Rating/
        JobsContext db = new JobsContext();
        public ActionResult Index()
        {
            return View(db.Rating.ToList());
        }

        //
        // GET: /Rating/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Rating.FirstOrDefault(x => x.RatingId == id));
        }

        //
        // GET: /Rating/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Rating/Create

        [HttpPost]
        public ActionResult Create(Rating collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.Rating.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Rating/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(db.Rating.FirstOrDefault(x => x.RatingId == id));
        }

        //
        // POST: /Rating/Edit/5

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

        //
        // GET: /Rating/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(db.Rating.FirstOrDefault(x => x.RatingId == id));
        }

        //
        // POST: /Rating/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Rating collection)
        {
            try
            {
                // TODO: Add delete logic here
                Rating obj = db.Rating.FirstOrDefault(x => x.RatingId == id);
                db.Rating.Remove(obj);
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
