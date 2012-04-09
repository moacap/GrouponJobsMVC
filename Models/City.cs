using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public List<Address> Address { get; set; }
        public bool Capital { get; set; }
        public int StateId { get; set; }

    }
}