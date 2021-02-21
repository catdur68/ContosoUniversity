using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        //The CourseID property is a foreign key, 
        //and the corresponding navigation property is Course. An Enrollment entity is associated with one Course entity
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
        //The question mark after the Grade type declaration indicates that the Grade property is nullable.

        public virtual Course Course { get; set; }
        //An enrollment record is for a single course, so there's a CourseID foreign key property 
        //and a Course navigation property

        public virtual Student Student { get; set; }
        //An enrollment record is for a single student, 
        //so there's a StudentID foreign key property and a Student navigation property
    }
}