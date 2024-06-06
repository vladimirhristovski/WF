using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP
{
    public partial class Print : Form
    {
        public List<TicketGame> games { get; set; }
        public decimal bet { get; set; }
        public string coef { get; set; }
        public string win { get; set; }
        public decimal tax { get; set; }

        public Print(List<TicketGame> games, decimal bet, string coef, string win)
        {
            InitializeComponent();
            this.games = games;
            this.bet = bet;
            this.coef = coef;
            this.win = win;
            this.tax = Decimal.Parse(win) * 0.1m;

            foreach (var game in games)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvGames);
                row.Cells[0].Value = game.game.code;
                row.Cells[1].Value = game.game.homeTeam + " - " + game.game.awayTeam;
                row.Cells[2].Value = game.getCoef();
                dgvGames.Rows.Add(row);
            }

            lblCoef.Text=this.coef;
            lblPay.Text=this.bet.ToString();
            lblTax.Text=this.tax.ToString();
            lblWin.Text=this.win;
        }

        public Print()
        {
            InitializeComponent();
        }
    }
}
