using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLeague.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        [Display(Name = "Name")]
        public string PlayerName { get; set; }

        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }

        [Display(Name = "Position")]
        public int PositionID { get; set; }

        [Display(Name = "Previous Years Batting Average")]
        public decimal PreviousYrsBattingAvg { get; set; }

        [Display(Name = "Number of Years Played")]
        public int NumYrsPlayed { get; set; }

        [Display(Name="Team")]
        public int TeamID { get; set; }
    }
}
