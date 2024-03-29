﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        //There's a one-to-zero-or-one relationship between the Instructor and the OfficeAssignment entities. 
        //An office assignment only exists in relation to the instructor it's assigned to, 
        //and therefore its primary key is also its foreign key to the Instructor entity. 
        //But the Entity Framework can't automatically recognize InstructorID as the primary key of this entity 
        //because its name doesn't follow the ID or classname ID naming convention. 
        //Therefore, the Key attribute is used to identify it as the key:
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        //By default EF treats the key as non-database-generated because the column is for an identifying relationship.
        //The ForeignKey Attribute is applied to the dependent class (Instructor class) to establish the relationship
        //and the OfficeAssignment entity has a non-nullable Instructor navigation property 
        //(because an office assignment can't exist without an instructor -- InstructorID is non-nullable).






        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}