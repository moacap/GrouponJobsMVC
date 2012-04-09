using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Disability
    {
        public int DisabilityId { get; set; }
        public string Name { get; set; }
        public List<Candidate> Candidate { get; set; }
    }
}