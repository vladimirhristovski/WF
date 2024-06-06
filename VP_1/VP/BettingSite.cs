using System;
using System.Collections;
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
    public partial class BettingSite : Form
    {
        public List<TicketGame> Games = new List<TicketGame>();
        public BettingSite()
        {
            InitializeComponent();
            lbTeams.Items.Add(new Team("Bayern Munchen", "Germany"));
            lbTeams.Items.Add(new Team("Borussia Dortmund", "Germany"));
            lbTeams.Items.Add(new Team("Manchester United", "England"));
            lbTeams.Items.Add(new Team("Manchester City", "England"));
            lbTeams.Items.Add(new Team("Pelister", "North Macedonia"));
            lbTeams.Items.Add(new Team("Vardar", "North Macedonia"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            AddTeam form = new AddTeam();

            if (form.ShowDialog() == DialogResult.OK)
            {
                lbTeams.Items.Add(form.team);
            }


        }

        private void btnAddToBilten_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItems.Count == 2 && mtbShifraEnter.Text.Length > 0)
            {
                Team home = lbTeams.SelectedItems[0] as Team;
                Team away = lbTeams.SelectedItems[1] as Team;
                if (home.Country != away.Country)
                {
                    lbTeams.ClearSelected();
                    MessageBox.Show("Не е дозволено додавање на натпревари од различна држава во билтен!");
                    return;
                }
                foreach (Game game in lbGames.Items)
                {
                    if (game.code == mtbShifraEnter.Text)
                    {
                        mtbShifraEnter.Text = "";
                        MessageBox.Show("Шифрата веќе постои!");
                        return;
                    }
                }
                Game new_game = new Game(home, away, nud1.Value, nud2.Value, nudX.Value, mtbShifraEnter.Text);
                lbGames.Items.Add(new_game);
                lbTeams.ClearSelected();
                nud1.Value = 1.0m;
                nud2.Value = 1.0m;
                nudX.Value = 1.0m;
                mtbShifraEnter.Text = "";
            }
        }

        private void tbShifraCheck_TextChanged(object sender, EventArgs e)
        {
            lbGames.ClearSelected();
            foreach (Game game in lbGames.Items)
            {
                if (game.code.Equals(tbShifraCheck.Text))
                {
                    lbGames.SelectedItem = game;
                    break;
                }
            }
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (lbGames.SelectedItems.Count == 1 && cbTip.SelectedItem != null)
            {
                foreach (TicketGame game in lbTickets.Items)
                {
                    if (game.game == lbGames.SelectedItem && game.type == cbTip.Text)
                    {
                        cbTip.SelectedItem = null;
                        lbGames.ClearSelected();
                        MessageBox.Show("Веќе постои натпревар со овој тип!");
                        return;
                    }
                }
                Games.Add(new TicketGame(lbGames.SelectedItem as Game, cbTip.Text));
                lbTickets.Items.Add(new TicketGame(lbGames.SelectedItem as Game, cbTip.Text));
                cbTip.SelectedItem = null;
                lbGames.ClearSelected();
                updateCoef();
            }
        }

        void updateCoef()
        {
            decimal coef = 1.0m;
            foreach (TicketGame game in lbTickets.Items)
            {
                coef *= game.getCoef();
            }
            tbTotalCoef.Text = coef.ToString("0.00");
            tbDobivka.Text = (coef * nudUplata.Value).ToString("0.00");
        }

        private void nudUplata_ValueChanged(object sender, EventArgs e)
        {
            updateCoef();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Games.Count != 0)
            {
                Print form = new Print(Games, nudUplata.Value, tbTotalCoef.Text, tbDobivka.Text);
                form.ShowDialog();
                Games.Clear();
                lbTickets.Items.Clear();
                updateCoef() ;
            }
            else
            {
                MessageBox.Show("Немате додадено натпревари за кладење!");
            }
        }
    }
}
