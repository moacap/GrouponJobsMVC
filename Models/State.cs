using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public string Sigla { get; set; }
        public List<City> City { get; set; }
        public int CountryId { get; set; }
    }
}