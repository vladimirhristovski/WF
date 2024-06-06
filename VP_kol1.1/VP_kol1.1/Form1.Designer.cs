namespace VP_kol1._1
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
            this.lbLevo = new System.Windows.Forms.ListBox();
            this.lbDesno = new System.Windows.Forms.ListBox();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbLength = new System.Windows.Forms.RadioButton();
            this.rbContent = new System.Windows.Forms.RadioButton();
            this.rbShowLength = new System.Windows.Forms.RadioButton();
            this.rbShowConsonants = new System.Windows.Forms.RadioButton();
            this.rbShowVowels = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLevo
            // 
            this.lbLevo.FormattingEnabled = true;
            this.lbLevo.Location = new System.Drawing.Point(22, 26);
            this.lbLevo.Name = "lbLevo";
            this.lbLevo.Size = new System.Drawing.Size(202, 316);
            this.lbLevo.TabIndex = 0;
            // 
            // lbDesno
            // 
            this.lbDesno.FormattingEnabled = true;
            this.lbDesno.Location = new System.Drawing.Point(546, 25);
            this.lbDesno.Name = "lbDesno";
            this.lbDesno.Size = new System.Drawing.Size(212, 303);
            this.lbDesno.TabIndex = 1;
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Checked = true;
            this.rbAsc.Location = new System.Drawing.Point(7, 10);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(74, 17);
            this.rbAsc.TabIndex = 2;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "ascending";
            this.rbAsc.UseVisualStyleBackColor = true;
            this.rbAsc.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(7, 33);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(80, 17);
            this.rbDesc.TabIndex = 3;
            this.rbDesc.Text = "descending";
            this.rbDesc.UseVisualStyleBackColor = true;
            this.rbDesc.CheckedChanged += new System.EventHandler(this.rbDesc_CheckedChanged);
            // 
            // rbLength
            // 
            this.rbLength.AutoSize = true;
            this.rbLength.Location = new System.Drawing.Point(9, 12);
            this.rbLength.Name = "rbLength";
            this.rbLength.Size = new System.Drawing.Size(54, 17);
            this.rbLength.TabIndex = 4;
            this.rbLength.Text = "length";
            this.rbLength.UseVisualStyleBackColor = true;
            this.rbLength.CheckedChanged += new System.EventHandler(this.rbLength_CheckedChanged);
            // 
            // rbContent
            // 
            this.rbContent.AutoSize = true;
            this.rbContent.Checked = true;
            this.rbContent.Location = new System.Drawing.Point(9, 35);
            this.rbContent.Name = "rbContent";
            this.rbContent.Size = new System.Drawing.Size(61, 17);
            this.rbContent.TabIndex = 5;
            this.rbContent.TabStop = true;
            this.rbContent.Text = "content";
            this.rbContent.UseVisualStyleBackColor = true;
            this.rbContent.CheckedChanged += new System.EventHandler(this.rbContent_CheckedChanged);
            // 
            // rbShowLength
            // 
            this.rbShowLength.AutoSize = true;
            this.rbShowLength.Location = new System.Drawing.Point(4, 3);
            this.rbShowLength.Name = "rbShowLength";
            this.rbShowLength.Size = new System.Drawing.Size(54, 17);
            this.rbShowLength.TabIndex = 6;
            this.rbShowLength.TabStop = true;
            this.rbShowLength.Text = "length";
            this.rbShowLength.UseVisualStyleBackColor = true;
            this.rbShowLength.CheckedChanged += new System.EventHandler(this.rbShowLength_CheckedChanged);
            // 
            // rbShowConsonants
            // 
            this.rbShowConsonants.AutoSize = true;
            this.rbShowConsonants.Location = new System.Drawing.Point(4, 26);
            this.rbShowConsonants.Name = "rbShowConsonants";
            this.rbShowConsonants.Size = new System.Drawing.Size(80, 17);
            this.rbShowConsonants.TabIndex = 7;
            this.rbShowConsonants.TabStop = true;
            this.rbShowConsonants.Text = "consonants";
            this.rbShowConsonants.UseVisualStyleBackColor = true;
            this.rbShowConsonants.CheckedChanged += new System.EventHandler(this.rbShowConsonants_CheckedChanged);
            // 
            // rbShowVowels
            // 
            this.rbShowVowels.AutoSize = true;
            this.rbShowVowels.Location = new System.Drawing.Point(4, 49);
            this.rbShowVowels.Name = "rbShowVowels";
            this.rbShowVowels.Size = new System.Drawing.Size(58, 17);
            this.rbShowVowels.TabIndex = 8;
            this.rbShowVowels.TabStop = true;
            this.rbShowVowels.Text = "vowels";
            this.rbShowVowels.UseVisualStyleBackColor = true;
            this.rbShowVowels.CheckedChanged += new System.EventHandler(this.rbShowVowels_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(4, 72);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 17);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(22, 368);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(202, 20);
            this.tbAdd.TabIndex = 10;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(257, 26);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(226, 20);
            this.tbFilter.TabIndex = 11;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.rbShowVowels);
            this.groupBox1.Controls.Add(this.rbShowConsonants);
            this.groupBox1.Controls.Add(this.rbShowLength);
            this.groupBox1.Location = new System.Drawing.Point(253, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 101);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDesc);
            this.groupBox2.Controls.Add(this.rbAsc);
            this.groupBox2.Location = new System.Drawing.Point(250, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbContent);
            this.groupBox3.Controls.Add(this.rbLength);
            this.groupBox3.Location = new System.Drawing.Point(389, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 72);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.lbDesno);
            this.Controls.Add(this.lbLevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLevo;
        private System.Windows.Forms.ListBox lbDesno;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.RadioButton rbLength;
        private System.Windows.Forms.RadioButton rbContent;
        private System.Windows.Forms.RadioButton rbShowLength;
        private System.Windows.Forms.RadioButton rbShowConsonants;
        private System.Windows.Forms.RadioButton rbShowVowels;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

