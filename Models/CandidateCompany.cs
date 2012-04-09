using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class CandidateCompany
    {
        public Candidate Candidate { get; set; }
        public Company Company { get; set; }
    }
}