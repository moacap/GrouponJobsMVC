using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<State> State { get; set; }
    }
}