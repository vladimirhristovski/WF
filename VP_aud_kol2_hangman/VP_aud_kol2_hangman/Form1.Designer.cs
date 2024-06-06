namespace VP_aud_kol2_hangman
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWord = new System.Windows.Forms.Label();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.tbAllLetters = new System.Windows.Forms.TextBox();
            this.pbAttmpts = new System.Windows.Forms.ProgressBar();
            this.pbTimeLeft = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра";
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.Location = new System.Drawing.Point(60, 71);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(86, 31);
            this.lbWord.TabIndex = 1;
            this.lbWord.Text = "label2";
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetter.Location = new System.Drawing.Point(63, 135);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(133, 38);
            this.tbLetter.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(202, 133);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(89, 40);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "OK";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // tbAllLetters
            // 
            this.tbAllLetters.Enabled = false;
            this.tbAllLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAllLetters.Location = new System.Drawing.Point(63, 223);
            this.tbAllLetters.Name = "tbAllLetters";
            this.tbAllLetters.Size = new System.Drawing.Size(650, 38);
            this.tbAllLetters.TabIndex = 4;
            // 
            // pbAttmpts
            // 
            this.pbAttmpts.Location = new System.Drawing.Point(63, 293);
            this.pbAttmpts.Name = "pbAttmpts";
            this.pbAttmpts.Size = new System.Drawing.Size(650, 23);
            this.pbAttmpts.TabIndex = 5;
            // 
            // pbTimeLeft
            // 
            this.pbTimeLeft.Location = new System.Drawing.Point(63, 339);
            this.pbTimeLeft.Name = "pbTimeLeft";
            this.pbTimeLeft.Size = new System.Drawing.Size(650, 23);
            this.pbTimeLeft.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Погодени букви";
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.AutoSize = true;
            this.lbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeft.Location = new System.Drawing.Point(651, 47);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(79, 29);
            this.lbTimeLeft.TabIndex = 8;
            this.lbTimeLeft.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.lbTimeLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbTimeLeft);
            this.Controls.Add(this.pbAttmpts);
            this.Controls.Add(this.tbAllLetters);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Бесилка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox tbAllLetters;
        private System.Windows.Forms.ProgressBar pbAttmpts;
        private System.Windows.Forms.ProgressBar pbTimeLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}

