using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrouponJobsMVC.Models;

namespace GrouponJobsMVC.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/
        JobsContext db = new JobsContext();
        public ActionResult Index()
        {
            return View(db.Category.ToList());
        }

        //
        // GET: /Category/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Category.FirstOrDefault(x => x.CategoryId == id));
        }

        //
        // GET: /Category/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Category/Create

        [HttpPost]
        public ActionResult Create(Category collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.Category.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Category/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(db.Category.FirstOrDefault(x => x.CategoryId == id));
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Category collection)
        {
            try
            {
                // TODO: Add update logic here
                Category obj = db.Category.FirstOrDefault(x => x.CategoryId == id);

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
        // GET: /Category/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(db.Category.FirstOrDefault(x => x.CategoryId == id));
        }

        //
        // POST: /Category/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Category collection)
        {
            try
            {
                // TODO: Add delete logic here
                Category obj = db.Category.FirstOrDefault(x => x.CategoryId == id);
                db.Category.Remove(obj);
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
