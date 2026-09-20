namespace StudentGradeCalculatorGUI
{
    partial class frmGradeCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStudent = new Label();
            txtStudent = new TextBox();
            lblGrade1 = new Label();
            txtGrade1 = new TextBox();
            txtGrade2 = new TextBox();
            lblGrade2 = new Label();
            txtGrade3 = new TextBox();
            lblGrade3 = new Label();
            btnCalc = new Button();
            lblAverage = new Label();
            lblAverageNum = new Label();
            lblLetterChar = new Label();
            lblLetter = new Label();
            btnClear = new Button();
            btnClose = new Button();
            chkHonors = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(232, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(314, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Grade Calculator";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(89, 72);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(192, 37);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student Name:";
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(287, 69);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(409, 43);
            txtStudent.TabIndex = 2;
            // 
            // lblGrade1
            // 
            lblGrade1.AutoSize = true;
            lblGrade1.Location = new Point(261, 127);
            lblGrade1.Name = "lblGrade1";
            lblGrade1.Size = new Size(117, 37);
            lblGrade1.TabIndex = 3;
            lblGrade1.Text = "Grade 1:";
            // 
            // txtGrade1
            // 
            txtGrade1.Location = new Point(384, 124);
            txtGrade1.Name = "txtGrade1";
            txtGrade1.Size = new Size(131, 43);
            txtGrade1.TabIndex = 4;
            // 
            // txtGrade2
            // 
            txtGrade2.Location = new Point(384, 178);
            txtGrade2.Name = "txtGrade2";
            txtGrade2.Size = new Size(131, 43);
            txtGrade2.TabIndex = 6;
            // 
            // lblGrade2
            // 
            lblGrade2.AutoSize = true;
            lblGrade2.Location = new Point(261, 181);
            lblGrade2.Name = "lblGrade2";
            lblGrade2.Size = new Size(117, 37);
            lblGrade2.TabIndex = 5;
            lblGrade2.Text = "Grade 2:";
            // 
            // txtGrade3
            // 
            txtGrade3.Location = new Point(384, 233);
            txtGrade3.Name = "txtGrade3";
            txtGrade3.Size = new Size(131, 43);
            txtGrade3.TabIndex = 8;
            // 
            // lblGrade3
            // 
            lblGrade3.AutoSize = true;
            lblGrade3.Location = new Point(261, 236);
            lblGrade3.Name = "lblGrade3";
            lblGrade3.Size = new Size(117, 37);
            lblGrade3.TabIndex = 7;
            lblGrade3.Text = "Grade 3:";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(305, 291);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(169, 43);
            btnCalc.TabIndex = 9;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(73, 343);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(119, 37);
            lblAverage.TabIndex = 10;
            lblAverage.Text = "Average:";
            // 
            // lblAverageNum
            // 
            lblAverageNum.AutoSize = true;
            lblAverageNum.Location = new Point(198, 343);
            lblAverageNum.Name = "lblAverageNum";
            lblAverageNum.Size = new Size(0, 37);
            lblAverageNum.TabIndex = 11;
            // 
            // lblLetterChar
            // 
            lblLetterChar.AutoSize = true;
            lblLetterChar.Location = new Point(679, 343);
            lblLetterChar.Name = "lblLetterChar";
            lblLetterChar.Size = new Size(0, 37);
            lblLetterChar.TabIndex = 13;
            // 
            // lblLetter
            // 
            lblLetter.AutoSize = true;
            lblLetter.Location = new Point(582, 343);
            lblLetter.Name = "lblLetter";
            lblLetter.Size = new Size(91, 37);
            lblLetter.TabIndex = 12;
            lblLetter.Text = "Letter:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(136, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(169, 43);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(476, 395);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(169, 43);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // chkHonors
            // 
            chkHonors.AutoSize = true;
            chkHonors.Location = new Point(539, 177);
            chkHonors.Name = "chkHonors";
            chkHonors.Size = new Size(233, 41);
            chkHonors.TabIndex = 16;
            chkHonors.Text = "Honors Student";
            chkHonors.UseVisualStyleBackColor = true;
            chkHonors.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frmGradeCalculator
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkHonors);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(lblLetterChar);
            Controls.Add(lblLetter);
            Controls.Add(lblAverageNum);
            Controls.Add(lblAverage);
            Controls.Add(btnCalc);
            Controls.Add(txtGrade3);
            Controls.Add(lblGrade3);
            Controls.Add(txtGrade2);
            Controls.Add(lblGrade2);
            Controls.Add(txtGrade1);
            Controls.Add(lblGrade1);
            Controls.Add(txtStudent);
            Controls.Add(lblStudent);
            Controls.Add(lblTitle);
            MinimumSize = new Size(430, 400);
            Name = "frmGradeCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grade Calculator";
            Load += frmGradeCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudent;
        private TextBox txtStudent;
        private Label lblGrade1;
        private TextBox txtGrade1;
        private TextBox txtGrade2;
        private Label lblGrade2;
        private TextBox txtGrade3;
        private Label lblGrade3;
        private Button btnCalc;
        private Label lblAverage;
        private Label lblAverageNum;
        private Label lblLetterChar;
        private Label lblLetter;
        private Button btnClear;
        private Button btnClose;
        private CheckBox chkHonors;
    }
}
