﻿using distribution_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace distribution_mvc.ViewModel
{
    public class ScheduleViewModel
    {
        public Student student { get; set; }
        public List<Schedule> schedule_collection { get; set; }
        public List<Course> course_collection { get; set; }
    }
}