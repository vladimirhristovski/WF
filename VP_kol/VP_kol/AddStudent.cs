using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_kol
{
    public partial class AddStudent : Form
    {
        public Student student { get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                student = new Student(tbName.Text, tbIndex.Text);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbIndex_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIndex.Text) || tbIndex.Text.Length != 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIndex, "Должината на индексот мора да биде 6 карактери!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbIndex, null);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Полето е задолжително!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
        }
    }
}
