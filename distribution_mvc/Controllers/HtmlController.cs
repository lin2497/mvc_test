using distribution_mvc.Models;
using distribution_mvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace distribution_mvc.Controllers
{
    public class HtmlController : Controller
    {
        int user_default_id = 1;

        CDataAccess data_access = new CDataAccess();

        public ActionResult Index()
        {
            ViewBag.github = "https://github.com/lin2497/mvc_test";
            return View();
        }

        public ActionResult Classmate()
        {
            ClassmateViewModel view_model = new ClassmateViewModel
            {
                clssmate_collection = data_access.getAllStudent()
            };
            return View(view_model);
        }
        public ActionResult Course()
        {
            CourseViewModel view_model = new CourseViewModel
            {
                course_collection = data_access.getAllCourse(),
                instructor_collection = data_access.getAllInstructor(),
                user_schedule = data_access.getSchedule(user_default_id)
            };
            return View(view_model);
        }

        public ActionResult Instructor()
        {
            InstructorViewModel view_model = new InstructorViewModel
            {
                course_collection = data_access.getAllCourse(),
                instructor_collection = data_access.getAllInstructor()
            };
            return View(view_model);
        }

        public ActionResult Schedule(int student_id)
        {
            ScheduleViewModel view_model = new ScheduleViewModel
            {
                student = data_access.getStudent(student_id),
                schedule_collection = data_access.getSchedule(student_id),
                course_collection = data_access.getAllCourse()
            };
            return View(view_model);
        }

        public ActionResult MySchedule()
        {
            MyScheduleViewModel view_model = new MyScheduleViewModel
            {
                user_self = data_access.getStudent(user_default_id),
                course_collection = data_access.getAllCourse(),
                schedule_collection = data_access.getSchedule(user_default_id)
            };
            return View(view_model);
        }

        public ActionResult addCourse(int course_id)
        {
            data_access.addSchedule(user_default_id, course_id);
            return RedirectToAction("Course", "Html");
        }
        public ActionResult removeCourse(int course_id)
        {
            data_access.removeSchedule(user_default_id, course_id);
            return RedirectToAction("MySchedule", "Html");
        }
    }
}