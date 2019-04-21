using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    class Position
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public Position()
        {
            Players = new List<Player>();
        }

    }
}
