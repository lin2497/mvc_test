//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace distribution_mvc.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Schedule
    {
        public Schedule()
        {

        }

        public Schedule(int student_id, int course_id)
        {
            this.student_id = student_id;
            this.course_id = course_id;
        }
        public int id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> course_id { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}