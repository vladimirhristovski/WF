using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_aud_kol2_hangman
{
    public partial class Form1 : Form
    {
        List<String> words = new List<String>()
        {
            "Argentina",
            "Macedonia",
            "France",
            "America",
            "Brazil",
            "Turkey"
        };
        Random rdm = new Random();
        HangmanState state;
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
            string word = words[rdm.Next(0, words.Count())];
            state = new HangmanState(word, word.Length > 6 ? 5 : 3);
            lbWord.Text = state.UpdateWordState();
            tbAllLetters.Text = state.UpdateAlphabet();
            lbTimeLeft.Text = "02:00";
            timeLeft = 120;
            pbTimeLeft.Value = 100;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (tbLetter.Text.Length == 1)
            {
                state.GuessLetter(tbLetter.Text[0]);
                lbWord.Text = state.UpdateWordState();
                tbAllLetters.Text = state.UpdateAlphabet();
                tbLetter.Clear();
                pbAttmpts.Value = state.PercentageOfFailedAttemptsUsed();

                if (state.GameOver())
                {
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                this.Close();
            }
            timeLeft--;
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lbTimeLeft.Text = $"{minutes}:{seconds}";
            pbTimeLeft.Value = (int)(100.0 * timeLeft / 120.0);
        }
    }
}
