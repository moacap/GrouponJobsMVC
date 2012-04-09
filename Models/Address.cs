using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public string Name { get; set; }
        public string Neighbourhood { get; set; }
        public virtual List<Candidate> Candidate { get; set; }
        public virtual List<Requisition> Requisition { get; set; }
        public int CEP { get; set; }

    }
}