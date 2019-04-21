using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_1
{
    class Student
    {
        [Key]
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
        [Required]
        public string Name { get; set; }
        [MinLength(10) , MaxLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        public bool RegisteredOn { get; set; }
        public List<StudentCourse> Courses { get; set; }
        public Student()
        {
            Courses = new List<StudentCourse>();
        }
        
    }
}
