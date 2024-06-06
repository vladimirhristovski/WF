using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_kol1._1
{
    public partial class Form1 : Form
    {
        public List<string> words = new List<string>();
        public List<string> filtered = new List<string>();
        public Form1()
        {
            InitializeComponent();
            words.Add("napredno programiranje");
            words.Add("vizuelno programiranje");
            words.Add("objektno programiranje");
            words.Add("dobra vizuelizacija");
            words.Add("vladimir");
            words.Add("hristovski");
            words.Add("da be");
            words.Add("ne");
            updateLeftList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAdd.Text.Length > 0)
            {
                lbLevo.Items.Add(tbAdd.Text);
                tbAdd.Clear();
            }
        }

        public void updateLeftList()
        {
            words.ForEach(w =>
            {
                lbLevo.Items.Add(w);
                lbDesno.Items.Add(w);
            });
        }

        public void filter()
        {
            lbDesno.Items.Clear();
            filtered.Clear();
            words.Where(w => w.ToLower().Contains(tbFilter.Text.ToLower())).ToList().ForEach(w =>
            {
                lbDesno.Items.Add(w);
                filtered.Add(w);
            });
        }

        public void sort()
        {
            filter();
            lbDesno.Items.Clear();
            if (rbAsc.Checked && rbContent.Checked)
            {
                filtered.OrderBy(w => w).ToList().ForEach(w => lbDesno.Items.Add(w));
            }
            else if (rbDesc.Checked && rbContent.Checked)
            {
                filtered.OrderByDescending(w => w).ToList().ForEach(w => lbDesno.Items.Add(w));
            }
            else if (rbAsc.Checked && rbLength.Checked)
            {
                filtered.OrderBy(w => w.Length).ToList().ForEach(w => lbDesno.Items.Add(w));
            }
            else if (rbDesc.Checked && rbLength.Checked)
            {
                filtered.OrderByDescending(w => w.Length).ToList().ForEach(w => lbDesno.Items.Add(w));
            }

        }

        public void update()
        {
            sort();
            lbDesno.Items.Clear();
            int counter = 0;
            if (rbShowLength.Checked)
            {
                filtered.Select(word => $"{word} ({word.Length})").ToList().ForEach(word => lbDesno.Items.Add(word));
            }
            else if (rbShowConsonants.Checked)
            {
                filtered.ForEach(w =>
                {
                    counter = 0;
                    Array chars = w.ToLower().ToCharArray();
                    foreach (char c in chars)
                    {
                        if (Char.IsLetter(c) && !c.Equals('a') && !c.Equals('e') && !c.Equals('i') && !c.Equals('o') && !c.Equals('u'))
                        {
                            counter++;
                        }
                    }
                    lbDesno.Items.Add($"{w} ({counter})constraints");
                });
            }
            else if (rbShowVowels.Checked)
            {
                filtered.ForEach(w =>
                {
                    counter = 0;
                    foreach (char c in w.ToLower())
                    {

                        if (Char.IsLetter(c) && c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o') || c.Equals('u'))
                        {
                            counter++;
                        }

                    }
                    lbDesno.Items.Add($"{w} ({counter})vowels");
                });
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void rbLength_CheckedChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void rbContent_CheckedChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void rbShowLength_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void rbShowConsonants_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void rbShowVowels_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
