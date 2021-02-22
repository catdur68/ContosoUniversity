using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //allows changes to datatype to be carry over the entire website
using System.ComponentModel.DataAnnotations.Schema;//allows to rename the columns' titles in the database


namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        //public int ID { get; set; }

        //[Required]
        //[StringLength(50)] //setting limits in the browser to the number of characters allowed (especially usefull for user input)
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First name must start with a Upper letter.") ]
        ////at this point we must implement a migration (add-migration + update-database in the Package Manager Console)
        //[Display(Name = "Last Name")]//how the label is displayed in the browser
        //public string LastName { get; set; }

        //[Required]
        //[Display(Name = "First Name")]
        //[StringLength(50, MinimumLength = 2, ErrorMessage = "First name cannot be longer than 50 characters.")]
        //[Column("FirstName")]//kind of aliasing the FirstMidName column
        //public string FirstMidName { get; set; }



        [DataType(DataType.Date)] //The DataType Enumeration provides for many data types, 
        //such as Date, Time, PhoneNumber, Currency, EmailAddress and more.

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //DataFormatString tells the browser how to always and specifically display the date attributes (using DataAnnotations namespace)
        //The ApplyFormatInEditMode setting specifies that the specified formatting should also be applied 
        //when the value is displayed in a text box for editing.(might not want with currency data)
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; } //this is the intrinsic type found in the database

        //[Display(Name = "Full Name")]
        //public string FullName //this does not create a column in the database
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstMidName;
        //    }
        //}



        public virtual ICollection<Enrollment> Enrollments { get; set; }
        //The Enrollments property is a navigation property
        //if a given Student row in the database has two related Enrollment rows
        //(rows that contain that student's primary key value in their StudentID foreign key column), 
        //that Student entity's Enrollments navigation property will contain those two Enrollment entities.
        //If a navigation property can hold multiple entities (as in many-to-many or one-to-many relationships),
        //its type must be a list in which entries can be added, deleted, and updated, such as ICollection.

    }
}