using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    [NotMapped]
    class Color
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Team> PrimaryTeams { get; set; }
        public List<Team> SecondaryTeams { get; set; }
        public Color()
        {
            SecondaryTeams = new List<Team>();
            PrimaryTeams = new List<Team>();
        }
       
    }
}
