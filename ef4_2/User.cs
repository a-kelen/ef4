using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
    class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Balance { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        public List<Bet> Bets { get; set; }
        public User()
        {
            Bets = new List<Bet>();
        }
    }
}
