namespace VP_kol
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeletePayments = new System.Windows.Forms.Button();
            this.nudPayment = new System.Windows.Forms.NumericUpDown();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.tbMaxPaymentsStudent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(30, 34);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(225, 277);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(30, 335);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(225, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Додади студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeletePayments
            // 
            this.btnDeletePayments.Location = new System.Drawing.Point(30, 378);
            this.btnDeletePayments.Name = "btnDeletePayments";
            this.btnDeletePayments.Size = new System.Drawing.Size(225, 23);
            this.btnDeletePayments.TabIndex = 2;
            this.btnDeletePayments.Text = "Избриши уплати";
            this.btnDeletePayments.UseVisualStyleBackColor = true;
            this.btnDeletePayments.Click += new System.EventHandler(this.btnDeletePayments_Click);
            // 
            // nudPayment
            // 
            this.nudPayment.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPayment.Location = new System.Drawing.Point(292, 34);
            this.nudPayment.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudPayment.Name = "nudPayment";
            this.nudPayment.Size = new System.Drawing.Size(172, 20);
            this.nudPayment.TabIndex = 3;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(292, 71);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(172, 23);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "Додади уплата";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Location = new System.Drawing.Point(289, 115);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(0, 13);
            this.lblStudentInfo.TabIndex = 5;
            // 
            // tbMaxPaymentsStudent
            // 
            this.tbMaxPaymentsStudent.Enabled = false;
            this.tbMaxPaymentsStudent.Location = new System.Drawing.Point(292, 335);
            this.tbMaxPaymentsStudent.Name = "tbMaxPaymentsStudent";
            this.tbMaxPaymentsStudent.Size = new System.Drawing.Size(172, 20);
            this.tbMaxPaymentsStudent.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.tbMaxPaymentsStudent);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.nudPayment);
            this.Controls.Add(this.btnDeletePayments);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Онлајн уплата";
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeletePayments;
        private System.Windows.Forms.NumericUpDown nudPayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.TextBox tbMaxPaymentsStudent;
    }
}

