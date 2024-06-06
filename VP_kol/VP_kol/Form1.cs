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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();
            if (form.ShowDialog() == DialogResult.OK)
            {
                lbStudents.Items.Add(form.student);
            }
            updateMaxPaymentsStudent();

        }

        public void updateLabel()
        {
            Student student = lbStudents.SelectedItem as Student;
            lblStudentInfo.Text = student.Details();
        }

        public void updateMaxPaymentsStudent()
        {
            Student student = lbStudents.Items[0] as Student;
            foreach (var item in lbStudents.Items)
            {
                Student s = item as Student;
                if (s.getTotalPayments() > student.getTotalPayments())
                {
                    student = s;
                }
            }
            tbMaxPaymentsStudent.Text = student.ToString();
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLabel();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            Student student = lbStudents.SelectedItem as Student;
            student.payments.Add(new Payment(nudPayment.Value));
            updateLabel();
            updateMaxPaymentsStudent();
            nudPayment.Value = 0;
        }

        private void btnDeletePayments_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Дали сте сигурни дека сакате да ги избришете уплатите за овој студент?","Дали сте сигурен?",MessageBoxButtons.OKCancel);
            Student student = lbStudents.SelectedItem as Student;
            if (dg == DialogResult.OK)
            {
                student.payments.Clear();
            }
            updateLabel();
            updateMaxPaymentsStudent();
        }
    }
}
