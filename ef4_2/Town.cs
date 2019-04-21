using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    class Town
    {
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
        public Town()
        {
            Teams = new List<Team>();
        }
    }
}
