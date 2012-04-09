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
                
            }
            if (!string.IsNullOrEmpty(fluency))
            {

            }


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
            ViewBag.MaritalStatusId = CandidateDropDown.MaritalStatus();
            ViewData["Address.CityId"] = CandidateDropDown.City();
            ViewBag.RequisitionId = CandidateDropDown.Requisition();
            ViewBag.DisabilityId = CandidateDropDown.Disability();
            ViewBag.CompanyCityId = CandidateDropDown.CompanyCity();
            ViewBag.CompanyCityId2 = CandidateDropDown.CompanyCity();
            ViewBag.languageNameId = CandidateDropDown.LanguageName();

            return View();
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

            ViewData["Address.CityId"] = CandidateDropDown.CityEdit(id);
            ViewBag.MaritalStatusId = CandidateDropDown.MaritalStatusEdit(id);
            ViewBag.DisabilityId = CandidateDropDown.DisabilityEdit(id);
            ViewBag.RequisitionId = CandidateDropDown.RequisitionEdit(id);
            ViewBag.RatingId = CandidateDropDown.RatingEdit(id);
            ViewBag.DispositionId = CandidateDropDown.DispositionEdit(id);

            return View(db.Candidate.FirstOrDefault(x => x.CandidateId == id));
        }


        //
        // POST: /Candidate/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Candidate collection, string languageName, string CityId, string graduate, string companyCityId, string companyCityId2, string companyName1, string companySalary1, string companyName2, string companySalary2, string coursesName1, string schoolName1, string start1, string end1, string coursesName2, string schoolName2, string start2, string end2, string coursesName3, string schoolName3, string start3, string end3)
        {
            try
            {
                // TODO: Add update logic here
                Candidate obj = db.Candidate.FirstOrDefault(x => x.CandidateId == id);

                obj.FirstName = collection.FirstName;
                obj.LastName = collection.LastName;
                obj.Email = collection.Email;
                obj.HomePhone = collection.HomePhone;
                obj.MobilePhone = collection.MobilePhone;
                obj.Gender = collection.Gender;
                obj.WillTravel = collection.WillTravel;
                obj.LastSalary = collection.LastSalary;
                obj.SalaryExpectation = collection.SalaryExpectation;
                obj.DisabilityId = collection.DisabilityId;
                obj.RequisitionId = collection.RequisitionId;
                obj.AddressId = collection.AddressId;
                obj.DispositionId = collection.DispositionId;
                obj.MaritalStatusId = collection.MaritalStatusId;
                obj.RatingId = collection.RatingId;
                obj.Company = collection.Company;
                obj.SalaryExpectation = collection.SalaryExpectation;
                obj.LastSalary = collection.LastSalary;
                obj.Courses = collection.Courses;
                obj.Resume = collection.Resume;
                obj.Address.CityId = collection.Address.CityId;
                obj.Birthday = collection.Birthday;
                Company company = new Company();
                try
                {
                    obj.Company.FirstOrDefault(x => x.NumberCompany == 1).Address.CityId = int.Parse(companyCityId);
                }
                catch
                {
                }
                try
                {
                    obj.Company.FirstOrDefault(x => x.NumberCompany == 2).Address.CityId = int.Parse(companyCityId2);
                }
                catch
                {
                }

                Courses courses = new Courses();
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 1).Name = coursesName1;
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 2).Name = coursesName2;
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 3).Name = coursesName3;
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 1).SchoolName = schoolName1;
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 2).SchoolName = schoolName2;
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 3).SchoolName = schoolName3;
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 1).Start = DateTime.Parse(start1);
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 2).Start = DateTime.Parse(start2);
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 3).Start = DateTime.Parse(start3);
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 1).End = DateTime.Parse(end1);
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 2).End = DateTime.Parse(end2);
                }
                catch
                { }
                try
                {
                    obj.Courses.FirstOrDefault(x => x.NumberCourses == 3).End = DateTime.Parse(end3);
                }
                catch
                { }
                obj.Courses.FirstOrDefault(x => x.NumberCourses == 1).Graduate = int.Parse(graduate);
                Language language = new Language();
                try
                {
                    obj.Language.FirstOrDefault(x => x.NumberLanguage == 1).Name = languageName;
                }
                catch { }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
