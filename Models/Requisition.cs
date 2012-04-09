using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Requisition
    {
        public int RequisitionId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Address Address { get; set; }
        public string Title { get; set; }
        public virtual Recruiter Recruiter { get; set; }
        public string SmallDescription { get; set; }
        public string BigDescription { get; set; }
        public int Status { get; set; }
        public int AddressId { get; set; }
        public int RecruiterId { get; set; }
        public int CategoryId { get; set; }
        public virtual List<Candidate> Candidate { get; set; }
        public int CandidateCount { get { return Candidate.Count(); } }
    }
}