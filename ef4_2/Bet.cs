using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    class Bet
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string Prediction { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
