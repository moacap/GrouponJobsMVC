using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public int CandidateId { get; set; }
        public string Name { get; set; }        
        public int Fluency { get; set; }
        public int? NumberLanguage { get; set; }
    }
}