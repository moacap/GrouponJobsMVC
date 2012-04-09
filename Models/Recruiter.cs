using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrouponJobsMVC.Models
{
    public class Recruiter
    {
        public int RecruiterId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Candidate> Candidate { get; set; }
        public List<Requisition> Requisition { get; set; }
    }
}