﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4_2
{
   
    class Game
    {
        [Key]
        public int Id { get; set; }
        public float AwayTeamBetRate { get; set; }
        public int AwayTeamGoals { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int DrawBetRate { get; set; }
        public float HomeTeamBetRate { get; set; }
        public int HomeTeamGoals { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public  string Result { get; set; }
        public DateTime DateTime { get; set; }
        public List<Bet> Bets { get; set; }
        public List<PlayerStatistic> PlayerStatistics { get; set; }

        public Game()
        {
            Bets = new List<Bet>();
            PlayerStatistics = new List<PlayerStatistic>();
        }

    }
}
