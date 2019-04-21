using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    class Player
    {
        [Key]
        public int Id { get; set; }
        public bool IsInjured { get; set; }
        [Required]
        public string Name { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int SquadNumber { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public List<PlayerStatistic> PlayerStatistics { get; set; }

        public Player()
        {
            PlayerStatistics = new List<PlayerStatistic>();
        }
    }
}
