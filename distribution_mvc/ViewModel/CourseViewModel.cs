using distribution_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace distribution_mvc.ViewModel
{
    public class CourseViewModel
    {
        public List<Course> course_collection { get; set; }
        public List<Instructor> instructor_collection { get; set; }
        public List<Schedule> user_schedule { get; set; }
    }
}