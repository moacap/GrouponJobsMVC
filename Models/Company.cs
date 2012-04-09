using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public decimal Salary { get; set; }
        public int AddressId { get; set; }
        public int? NumberCompany { get; set; }
    }
}