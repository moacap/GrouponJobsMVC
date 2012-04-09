using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Address Address { get; set; }
        public string Email { get; set; }
        public int HomePhone { get; set; }
        public int MobilePhone { get; set; }
        public virtual Requisition Requisition { get; set; }
        public int Gender { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public int WillTravel { get; set; }
        public decimal LastSalary { get; set; }
        public decimal SalaryExpectation { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public virtual Disposition Disposition { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Disability Disability { get; set; }
        public virtual List<Company> Company { get; set; }
        public virtual List<Courses> Courses { get; set; }
        public virtual List<Resume> Resume { get; set; }
        public virtual Workflow Workflow {get; set;}
        public virtual Recruiter Recruiter { get; set; }
        public int RecruiterId { get; set; }
        public int DisabilityId { get; set; }
        public int RequisitionId { get; set; }
        public int AddressId { get; set; }
        public int DispositionId { get; set; }
        public int MaritalStatusId { get; set; }
        public int WorkflowId { get; set; }
        public int RatingId { get; set; }
        public DateTime Birthday { get; set; }
        public virtual List<Language> Language { get; set; }  
    }
}