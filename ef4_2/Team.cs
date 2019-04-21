using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
   
    class Team
    {
        [Key]
        public int Id { get; set; }
        public double Budget { get; set; }
        public int Initials { get; set; }
        public string LogoUrl { get; set; }
        [Required]
        public string Name { get; set; }
        public int PrimaryKitColorId { get; set; }
        public Color PrimaryKitColor { get; set; }
        public int SecondaryKitColorId { get; set; }
        public Color SecondaryKitColor { get; set; }
        public int TownId { get; set; }
        public Town Town { get; set; }
        public List<Game> HomeGames { get; set; }
        public List<Game> AwayGames { get; set; }
        public Team()
        {
            HomeGames = new List<Game>();
            AwayGames = new List<Game>();
        }

    }
}
