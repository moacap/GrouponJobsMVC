using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using GrouponJobsMVC.Models;
using GrouponJobsMVC.Views.Candidate;
namespace GrouponJobsMVC.Controllers
{
    public class CandidateController : Controller
    {
        //
        // GET: /Candidate/
        JobsContext db = new JobsContext();
        public ActionResult Index()
        {
            ViewData["Address.CityId"] = CandidateDropDown.City();
            ViewData["RequisitionId"] = CandidateDropDown.Requisition();
            ViewData["languageNameId"] = CandidateDropDown.LanguageName();
            return View(db.Candidate.ToList());
        }
        //
        //POST: /Candidate/

        [HttpPost]
        public ActionResult Index(string candidateName, int? salaryExpectation, string language, string fluency, string Graduate, string birthday, string Gender, string WillTravel, string CityId, string RequisitionId)
        {
            var candidate = db.Candidate.ToList();
            IFormatProvider theCultureInfo = new System.Globalization.CultureInfo("en-GB", true);
            if (!string.IsNullOrEmpty(candidateName))
                candidate = candidate.Where(a => a.FirstName.Contains(candidateName)).ToList();

            if (salaryExpectation.HasValue)
                candidate = candidate.Where(a => a.SalaryExpectation <= salaryExpectation).ToList();

            if (!string.IsNullOrEmpty(Gender))
                candidate = candidate.Where(a => a.Gender == int.Parse(Gender)).ToList();

            if (!string.IsNullOrEmpty(WillTravel))
                candidate = candidate.Where(a => a.WillTravel == int.Parse(WillTravel)).ToList();

            if (!string.IsNullOrEmpty(CityId))
                candidate = candidate.Where(a => a.Address.CityId == int.Parse(CityId)).ToList();

            if (!string.IsNullOrEmpty(RequisitionId))
                candidate = candidate.Where(a => a.RequisitionId == int.Parse(RequisitionId)).ToList();

            if (!string.IsNullOrEmpty(birthday))
            {
                candidate = candidate.Where(a => a.Birthday.Year == DateTime.ParseExact(birthday, "yyyy", theCultureInfo).Year).ToList();
            }
            if (!string.IsNullOrEmpty(language))
            {
                candidate = candidate.Where(a => a.Language.FirstOrDefault(x => x.LanguageId == int.Parse(language)) != null).ToList();
            }
            if (!string.IsNullOrEmpty(fluency))
                candidate = candidate.Where(x => x.Language.FirstOrDefault(c => c.Fluency == int.Parse(fluency)) != null).ToList();


            ViewData["Address.CityId"] = CandidateDropDown.City();
            ViewData["RequisitionId"] = CandidateDropDown.Requisition();
            ViewData["languageNameId"] = CandidateDropDown.LanguageName();
            return View(candidate);
        }


        //
        // GET: /Candidate/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Candidate.FirstOrDefault(x => x.CandidateId == id));
        }

        //
        // GET: /Candidate/Create

        public ActionResult Create()
        {

            return View();
        }

        //
        // POST: Candidate CompanyAdd

        [HttpPost]
        public ActionResult CompanyAdd(Candidate collection)
        {
            return Json(new { success = true });
        }

        //
        // POST: /Candidate/Create

        [HttpPost]
        public ActionResult Create(Candidate candidates)
        {
            try
            {
                candidates.DispositionId = 1;
                candidates.RatingId = 1;
                candidates.DateCreated = DateTime.Now;
                candidates.LastUpdated = DateTime.Now;
                candidates.RecruiterId = 2;
                candidates.WorkflowId = 1;
                db.Candidate.Add(candidates);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Candidate/Edit/5

        public ActionResult Edit(int id)
        {

            return View(db.Candidate.FirstOrDefault(x => x.CandidateId == id));
        }


        //
        // POST: /Candidate/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Candidate collection)
        {
            try
            {
                collection.LastUpdated = DateTime.Now;
                db.Candidate.Attach(collection);
                db.Entry(collection).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.ErroAtualizar = "Erro ao atualizar o candidato!";
                return View(db.Candidate.FirstOrDefault(x =>x.CandidateId == id));
            }
        }

        //
        // GET: /Candidate/Delete/5

        public ActionResult Delete(int id)
        {
            return View(db.Candidate.FirstOrDefault(x => x.CandidateId == id));
        }

        //
        // POST: /Candidate/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Candidate collection)
        {
            try
            {
                // TODO: Add delete logic here
                Candidate obj = db.Candidate.FirstOrDefault(c => c.CandidateId == id);

                db.Candidate.Remove(obj);

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
