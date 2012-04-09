using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrouponJobsMVC.Models;
namespace GrouponJobsMVC.Views.Requisition
{
    public static class RequisitionDropDown
    {
        static JobsContext db = new JobsContext();
        public static SelectList Category()
        {
            var CategoryQuery = from d in db.Category
                                orderby d.Name
                                select new { Text = d.Name, Value = d.CategoryId };
            return new SelectList(CategoryQuery.Distinct(), "Value", "Text");
        }

        public static SelectList City()
        {
            var CityQuery = from d in db.City
                            orderby d.Name
                            select new { Text = d.Name, Value = d.CityId };
            return new SelectList(CityQuery.Distinct(), "Value", "Text");
        }

        public static SelectList Recruiter()
        {
            var RecruiterQuery = from d in db.Recruiter
                                 orderby d.Name
                                 select new { Text = d.Name, Value = d.RecruiterId };
            return new SelectList(RecruiterQuery.Distinct(), "Value", "Text");
        }

        public static SelectList CategoryEdit(int id)
        {
            var CategoryQuery = from d in db.Category
                                orderby d.Name
                                select new { Text = d.Name, Value = d.CategoryId };
            id = db.Requisition.Where(x => x.RequisitionId == id).Select(x => x.CategoryId).Single();
            return new SelectList(CategoryQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList CityEdit(int id)
        {
            var CityQuery = from d in db.City
                            orderby d.Name
                            select new { Text = d.Name, Value = d.CityId };
            id = db.Requisition.Where(x => x.RequisitionId == id).Select(x => x.Address.CityId).Single();
            return new SelectList(CityQuery.Distinct(), "Value", "Text", id);
        }

        public static SelectList RecruiterEdit(int id)
        {
            var RecruiterQuery = from d in db.Recruiter
                                 orderby d.Name
                                 select new { Text = d.Name, Value = d.RecruiterId };
            id = db.Requisition.Where(x => x.RequisitionId == id).Select(x => x.RecruiterId).Single();
            return new SelectList(RecruiterQuery.Distinct(), "Value", "Text", id);
        }

    }
}