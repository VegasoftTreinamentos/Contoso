using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
   public class Instructor : Person
   {
      [DataType(DataType.Date)]
      [Display(Name = "Admissão")]
      public DateTime HireDate { get; set; }

        [Display(Name = "Disciplinas")]
        public virtual ICollection<Course> Courses { get; set; }
        [Display(Name = "Sala")]
        public virtual OfficeAssignment OfficeAssignment { get; set; }
   }
}
