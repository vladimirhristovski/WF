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
    public partial class AddTeam : Form
    {

        public Team team {  get; set; }
        public AddTeam()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0 && tbCountry.Text.Length > 0)
            {
                team = new Team(tbName.Text,tbCountry.Text);
                this.DialogResult = DialogResult.OK;
                return;
            }
            this.DialogResult= DialogResult.Cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }
    }
}
