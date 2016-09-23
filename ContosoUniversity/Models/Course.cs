using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
   public class Course
   {
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      [Display(Name = "Número")]
      public int CourseID { get; set; }

      [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Nome do Curso")]
        public string Title { get; set; }

      [Range(0, 5)]
        [Display(Name = "Créditos")]
        public int Credits { get; set; }

      [Display(Name = "Departamentos")]
      public int DepartmentID { get; set; }

        [Display(Name = "Departamento")]
        public virtual Department Department { get; set; }
        [Display(Name = "Matrículas")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        [Display(Name = "Professores")]
        public virtual ICollection<Instructor> Instructors { get; set; }
   }
}