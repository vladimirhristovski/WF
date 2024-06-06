using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP
{
    public class Game
    {
        public Team homeTeam {  get; set; }
        public Team awayTeam { get; set; }
        public decimal coef1 { get; set; }
        public decimal coef2 { get; set; }
        public decimal coefX { get; set; }
        public string code { get; set; }

        public Game(Team homeTeam, Team awayTeam, decimal coef1, decimal coef2, decimal coefX, string code)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.coef1 = coef1;
            this.coef2 = coef2;
            this.coefX = coefX;
            this.code = code;
        }

        public override string ToString()
        {
            return $"({code}) {homeTeam.Name} - {awayTeam.Name}";
        }
    }
}
