using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrouponJobsMVC.Models
{
    public class Courses
    {
        public int CoursesId { get; set; }
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? NumberCourses { get; set; }
        public int Graduate { get; set; }
    }
}