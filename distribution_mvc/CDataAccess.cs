using distribution_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace distribution_mvc
{
    public class CDataAccess
    {
        public mvc_course_testEntities db = new mvc_course_testEntities();
        public CDataAccess()
        {


        }
        public List<Student> getAllStudent()
        {
            return db.Student.ToList<Student>();
        }
        public Student getStudent(int student_id)
        {
            return db.Student.Where(s => s.id == student_id).FirstOrDefault();
        }
        public List<Schedule> getSchedule(int student_id)
        {
            return db.Schedule.Where(x => x.student_id == student_id).ToList<Schedule>();
        }
        public void addSchedule(int student_id, int course_id)
        {
            db.Schedule.Add(new Schedule(student_id, course_id));
            db.SaveChanges();
        }

        public void removeSchedule(int student_id, int course_id)
        {
            Schedule course_to_remove = getSchedule(student_id, course_id);
            db.Schedule.Remove(course_to_remove);
            db.SaveChanges();
        }
        public Schedule getSchedule(int student_id, int course_id)
        {
            return db.Schedule.Where(s => s.student_id == student_id && s.course_id == course_id).FirstOrDefault();
        }

        public List<Instructor> getAllInstructor()
        {
            return db.Instructor.ToList<Instructor>();
        }

        public Course getCourse(int course_id)
        {
            return db.Course.Where(c => c.id == course_id).FirstOrDefault();
        }
        public List<Course> getAllCourse()
        {
            return db.Course.ToList<Course>();
        }
    }
}