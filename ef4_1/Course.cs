using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_1
{
    class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public float Price { get; set; }
        public List<Resourse> Resourses { get; set; }
        public List<StudentCourse> Students { get; set; }
        public Course()
        {
            Resourses = new List<Resourse>();
            Students = new List<StudentCourse>();
        }
    }
}
