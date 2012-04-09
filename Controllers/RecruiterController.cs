using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrouponJobsMVC.Models;
namespace GrouponJobsMVC.Controllers
{
    public class RecruiterController : Controller
    {
        //
        // GET: /Recruiter/
        JobsContext db = new JobsContext();
        public ActionResult Index()
        {

            return View(db.Recruiter.ToList());
        }

        //
        // GET: /Recruiter/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Recruiter.FirstOrDefault(x => x.RecruiterId == id));
        }

        //
        // GET: /Recruiter/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Recruiter/Create

        [HttpPost]
        public ActionResult Create(Recruiter collection)
        {
            try
            {
                db.Recruiter.Add(collection);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Recruiter/Edit/5

        public ActionResult Edit(int id)
        {
            return View(db.Recruiter.FirstOrDefault(x => x.RecruiterId == id));
        }

        //
        // POST: /Recruiter/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Recruiter collection)
        {
            try
            {
                // TODO: Add update logic here
                Recruiter obj = db.Recruiter.FirstOrDefault(x => x.RecruiterId == id);
                obj.Name = collection.Name;
                obj.Email = collection.Email;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Recruiter/Delete/5

        public ActionResult Delete(int id)
        {
            return View(db.Recruiter.FirstOrDefault(x => x.RecruiterId == id));
        }

        //
        // POST: /Recruiter/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Recruiter obj = db.Recruiter.FirstOrDefault(x => x.RecruiterId == id);
                db.Recruiter.Remove(obj);
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
