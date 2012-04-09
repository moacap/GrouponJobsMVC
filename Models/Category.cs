﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual List<Requisition> Requisition { get; set; }
    }
}