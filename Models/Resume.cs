using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Resume
    {
        public int ResumeId { get; set; }
        public string ResumeBody { get; set; }
        public int CandidateId { get; set; }
    }
}