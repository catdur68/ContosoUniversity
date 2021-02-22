using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor : Person
    {
        //public int ID { get; set; }

        //[Display(Name = "Last Name"), StringLength(50, MinimumLength = 1)]
        //public string LastName { get; set; }

        //[Column("FirstName"), Display(Name = "First Name"), StringLength(50, MinimumLength = 1)]
        //public string FirstMidName { get; set; }



        [DataType(DataType.Date), Display(Name = "Hire Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get { return LastName + ", " + FirstMidName; }
        //}


        //The Courses and OfficeAssignment properties are navigation properties
        //An instructor can teach any number of courses, so Courses is defined as a collection of Course entities.
        public virtual ICollection<Course> Courses { get; set; }
        //Our business rules state an instructor can only have at most one office, 
        //so OfficeAssignment is defined as a single OfficeAssignment entity (which may be null if no office is assigned).
        public virtual OfficeAssignment OfficeAssignment { get; set; } //need to create an OfficeAssignment entity in Models
        //The Instructor entity has a nullable OfficeAssignment navigation property (because an instructor might not have an office assignment),
    }
}