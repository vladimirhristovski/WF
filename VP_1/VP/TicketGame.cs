using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP
{
    public class TicketGame
    {
        public Game game {  get; set; }
        public string type { get; set; }

        public TicketGame(Game game, string type)
        {
            this.game = game;
            this.type = type;
        }

        public decimal getCoef()
        {
            switch(type)
            {
                case "1":
                    return game.coef1;
                case "2": return game.coef2;
                default: return game.coefX;
            }
        }
        public override string ToString()
        {
            return $"{game} - {type} - {getCoef()}";
        }
    }
}
