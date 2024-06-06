using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_aud_kol2_hangman
{
    public class HangmanState
    {
        public string word { get; set; }
        public HashSet<char> wordLetters { get; set; } = new HashSet<char>();
        public HashSet<char> attemptedLetters { get; set; } = new HashSet<char>();
        public int maxFailedAttempts { get; set; }
        public int failedAttempts { get; set; }

        public HangmanState(string word, int maxFailedAttempts)
        {
            this.word = word;
            this.maxFailedAttempts = maxFailedAttempts;
            foreach (char letter in word.ToCharArray())
            {
                this.wordLetters.Add(char.ToLower(letter));
            }
        }

        public void GuessLetter(char letter)
        {
            if (this.attemptedLetters.Contains(letter))
            {
                return;
            }

            if (this.wordLetters.Contains(char.ToLower(letter)))
            {
                this.wordLetters.Remove(char.ToLower(letter));
                this.attemptedLetters.Add(char.ToLower(letter));
            }
            else
            {
                this.attemptedLetters.Add(char.ToLower(letter));
                this.failedAttempts++;
            }
        }

        public string UpdateWordState()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in word)
            {
                if (this.wordLetters.Contains(char.ToLower(item)))
                {
                    sb.Append("_");
                }
                else
                {
                    sb.Append(item);
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public string UpdateAlphabet()
        {
            StringBuilder sb = new StringBuilder();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (this.attemptedLetters.Contains(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append("_");
                }
                sb.Append(' ');
            }
            return sb.ToString();
        }

        public int PercentageOfFailedAttemptsUsed()
        {
            return (int)(100.0 * (double)failedAttempts / maxFailedAttempts);
        }

        public bool GameOver()
        {
            return failedAttempts == maxFailedAttempts || wordLetters.Count() == 0;
        }
    }
}
