using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Workflow
    {
        public int WorkflowId { get; set; }
        public string Name { get; set; }
        public virtual List<Candidate> Candidate { get; set; }
    }
}