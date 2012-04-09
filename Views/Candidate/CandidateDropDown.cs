using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrouponJobsMVC.Models;
namespace GrouponJobsMVC.Views.Candidate
{
    public static class CandidateDropDown
    {
        static JobsContext db = new JobsContext();

        public static SelectList MaritalStatus()
        {
            var MaritalStatusQuery = from d in db.MaritalStatus
                                     orderby d.Name
                                     select new { Text = d.Name, Value = d.MaritalStatusId };
            return new SelectList(MaritalStatusQuery.Distinct(), "Value", "Text");
        }

        public static SelectList Address()
        {
            var AddressQuery = from d in db.Address
                               orderby d.Name
                               select new { Text = d.Name, Value = d.AddressId };
            return new SelectList(AddressQuery.Distinct(), "Value", "Text");
        }

        public static SelectList Requisition()
        {
            var RequisitionQuery = from d in db.Requisition
                                   orderby d.Title
                                   select new { Text = d.Title, Value = d.RequisitionId };
            return new SelectList(RequisitionQuery.Distinct(), "Value", "Text");
        }

        public static SelectList Disability()
        {
            var DisabilityQuery = from d in db.Disability
                                  orderby d.Name
                                  select new { Text = d.Name, Value = d.DisabilityId };
            return new SelectList(DisabilityQuery.Distinct(), "Value", "Text");
        }

        public static SelectList DisabilityEdit(int id)
        {
            var DisabilityQuery = from d in db.Disability
                                  orderby d.Name
                                  select new { Text = d.Name, Value = d.DisabilityId };
            id = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.DisabilityId).Single();
            return new SelectList(DisabilityQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList DispositionEdit(int id)
        {
            var DispositionQuery = from d in db.Disposition
                                   orderby d.Name
                                   select new { Text = d.Name, Value = d.DispositionId };
            id = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.DispositionId).Single();
            return new SelectList(DispositionQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList RatingEdit(int id)
        {
            var RatingQuery = from d in db.Rating
                              orderby d.Name
                              select new { Text = d.Name, Value = d.RatingId };
            id = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.RatingId).Single();
            return new SelectList(RatingQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList RequisitionEdit(int id)
        {
            var RequisitionQuery = from d in db.Requisition
                                   orderby d.Title
                                   select new { Text = d.Title, Value = d.RequisitionId };
            id = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.RequisitionId).Single();
            return new SelectList(RequisitionQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList RecruiterEdit(int id)
        {
            var RecruiterQuery = from d in db.Recruiter
                                 orderby d.Name
                                 select new { Text = d.Name, Value = d.RecruiterId };
            id = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.Requisition.RecruiterId).Single();
            return new SelectList(RecruiterQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList MaritalStatusEdit(int id)
        {
            var MaritalStatusQuery = from d in db.MaritalStatus
                                     orderby d.Name
                                     select new { Text = d.Name, Value = d.MaritalStatusId };
            id = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.MaritalStatusId).Single();
            return new SelectList(MaritalStatusQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList City()
        {
            var CityQuery = from d in db.City
                            orderby d.Name
                            select new { Text = d.Name, Value = d.CityId };
            return new SelectList(CityQuery.Distinct(), "Value", "Text");
        }

        public static SelectList CityEdit(int id)
        {
            var CityQuery = from d in db.City
                            orderby d.Name
                            select new { Text = d.Name, Value = d.CityId };
            id = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.Address.CityId).Single();
            return new SelectList(CityQuery.Distinct(), "Value", "Text", id);
        }


        public static SelectList CompanyCity()
        {
            var CompanyCityQuery = from d in db.City
                                   orderby d.Name
                                   select new { Text = d.Name, Value = d.CityId };

            return new SelectList(CompanyCityQuery.Distinct(), "Value", "Text");
        }

        public static SelectList CompanyCityEdit(int id, int indexCompany)
        {
            var CompanyCityQuery = from d in db.City
                                   orderby d.Name
                                   select new { Text = d.Name, Value = d.CityId };

            int a = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.Company.FirstOrDefault(y => y.NumberCompany == indexCompany).Address.CityId).Single();
            return new SelectList(CompanyCityQuery.Distinct(), "Value", "Text", a);
        }

        public static List<SelectListItem> Gender(int value)
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Masculino", Value = "0", Selected = value == 0 });

            items.Add(new SelectListItem { Text = "Feminino", Value = "1", Selected = value == 1 });

            return items;
        }

        public static List<SelectListItem> WillTravel(int value)
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Sim", Value = "0", Selected = value == 0 });

            items.Add(new SelectListItem { Text = "Não", Value = "1", Selected = value == 1 });

            return items;
        }

        public static List<SelectListItem> Graduate(int value)
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Sim", Value = "0", Selected = value == 0 });

            items.Add(new SelectListItem { Text = "Não", Value = "1", Selected = value == 1 });

            return items;
        }

        public static SelectList LanguageName()
        {
            var NameQuery = from d in db.Language
                            orderby d.Name
                            select new { Text = d.Name, Value = d.LanguageId };
            return new SelectList(NameQuery.Distinct(), "Value", "Text");
        }

        public static SelectList LanguageNameEdit(int id, int indexLanguage)
        {
            var NameQuery = from d in db.Language
                            orderby d.Name
                            select new { Text = d.Name, Value = d.LanguageId };
            int i = db.Candidate.Where(x => x.CandidateId == id).Select(x => x.Language.FirstOrDefault( y => y.NumberLanguage == indexLanguage).LanguageId).Single();
            return new SelectList(NameQuery.Distinct(), "Value", "Text", i);
        }

        public static List<SelectListItem> Fluency(int value)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            //items.Add(new SelectListItem { Text = "None", Value = "0", Selected = value == 0 });
            items.Add(new SelectListItem { Text = "Basico", Value = "0", Selected = value == 0 });
            items.Add(new SelectListItem { Text = "Intermediario", Value = "1", Selected = value == 1 });
            items.Add(new SelectListItem { Text = "Avançado", Value = "2", Selected = value == 2 });
            items.Add(new SelectListItem { Text = "Fluente", Value = "3", Selected = value == 3 });
            return items;
        }
    }
}