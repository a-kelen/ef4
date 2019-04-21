using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_1
{
    class Resourse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        public ResourseType ResourseType { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
   enum  ResourseType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}

