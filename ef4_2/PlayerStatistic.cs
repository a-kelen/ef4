using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    class PlayerStatistic
    {
 
        public int PlayerId { get; set; }
        public Player Player { get; set; }
      
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int Assists { get; set; }
        public int MinutesPlayed { get; set; }
        public int ScoredGoal { get; set; }
    }
}
