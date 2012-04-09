using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrouponJobsMVC.Models;
using GrouponJobsMVC.Views.Requisition;
namespace GrouponJobsMVC.Controllers
{
    public class RequisitionController : Controller
    {
        //
        // GET: /Requisition/
        JobsContext db = new JobsContext();
        public ActionResult Index()
        {            
            return View(db.Requisition.ToList());
        }

        //
        // GET: /Requisition/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Requisition.FirstOrDefault(x => x.RequisitionId == id));
        }

        //
        // GET: /Requisition/Create

        public ActionResult Create()
        {
            ViewBag.CategoryId = RequisitionDropDown.Category();
            ViewData["Address.CityId"] = RequisitionDropDown.City();
            ViewBag.RecruiterId = RequisitionDropDown.Recruiter();
            return View();
        } 

        //
        // POST: /Requisition/Create

        [HttpPost]
        public ActionResult Create(Requisition collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.Requisition.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Requisition/Edit/5
 
        public ActionResult Edit(int id)
        {
            ViewBag.CategoryId = RequisitionDropDown.CategoryEdit(id);
            ViewData["Address.CityId"] = RequisitionDropDown.CityEdit(id);
            ViewBag.RecruiterId = RequisitionDropDown.RecruiterEdit(id);
            return View(db.Requisition.FirstOrDefault(x => x.RequisitionId == id));
        }

        //
        // POST: /Requisition/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Requisition collection)
        {
            try
            {
                // TODO: Add update logic here
                Requisition obj = db.Requisition.FirstOrDefault(x => x.RequisitionId == id);

                obj.Title = collection.Title;
                obj.SmallDescription = collection.SmallDescription;
                obj.BigDescription = collection.BigDescription;
                obj.CategoryId = collection.CategoryId;
                obj.RecruiterId = collection.RecruiterId;
                obj.Address.CityId = collection.Address.CityId;
                obj.Address.Name = collection.Address.Name;
                obj.Address.CEP = collection.Address.CEP;

                db.SaveChanges();
    
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Requisition/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(db.Requisition.FirstOrDefault(x => x.RequisitionId == id));
        }

        //
        // POST: /Requisition/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Requisition obj = db.Requisition.FirstOrDefault(x => x.RequisitionId == id);

                db.Requisition.Remove(obj);
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
