using distribution_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace distribution_mvc.ViewModel
{
    public class MyScheduleViewModel
    {
        public Student user_self { get; set; }
        public List<Course> course_collection { get; set; }
        public List<Schedule> schedule_collection { get; set; }

    }
}