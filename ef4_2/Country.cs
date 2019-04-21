using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        List<Country> Countries { get; set; }

        public Country()
        {
            Countries = new List<Country>();
        }
    }
}
