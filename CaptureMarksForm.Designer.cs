namespace StudentGradeBookSystems
{
    partial class CaptureMarksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureMarksForm));
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblFinalExam = new System.Windows.Forms.Label();
            this.lblModuleMark = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.txtModuleMark = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtFinalExam = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCoursework = new System.Windows.Forms.TextBox();
            this.lblCoursework = new System.Windows.Forms.Label();
            this.lblCaptureMarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(26, 127);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(110, 27);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "StudentID";
            this.lblStudentID.Click += new System.EventHandler(this.txtStudentID_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(26, 219);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(57, 27);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Test";
            this.lblTest.Click += new System.EventHandler(this.ttxTest_Click);
            // 
            // lblFinalExam
            // 
            this.lblFinalExam.AutoSize = true;
            this.lblFinalExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalExam.Location = new System.Drawing.Point(26, 288);
            this.lblFinalExam.Name = "lblFinalExam";
            this.lblFinalExam.Size = new System.Drawing.Size(121, 27);
            this.lblFinalExam.TabIndex = 2;
            this.lblFinalExam.Text = "Final Exam";
            this.lblFinalExam.Click += new System.EventHandler(this.txtFinaleExam_Click);
            // 
            // lblModuleMark
            // 
            this.lblModuleMark.AutoSize = true;
            this.lblModuleMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModuleMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleMark.Location = new System.Drawing.Point(26, 382);
            this.lblModuleMark.Name = "lblModuleMark";
            this.lblModuleMark.Size = new System.Drawing.Size(133, 27);
            this.lblModuleMark.TabIndex = 3;
            this.lblModuleMark.Text = "ModuleMark";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.Location = new System.Drawing.Point(26, 256);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(127, 27);
            this.lblModule.TabIndex = 4;
            this.lblModule.Text = "Assignment";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(26, 419);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(73, 27);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // cmbModule
            // 
            this.cmbModule.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(204, 159);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(157, 28);
            this.cmbModule.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Module";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(148, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 64);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtStudentID.Location = new System.Drawing.Point(204, 127);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 26);
            this.txtStudentID.TabIndex = 9;
            // 
            // txtTest
            // 
            this.txtTest.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTest.Location = new System.Drawing.Point(204, 224);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(200, 26);
            this.txtTest.TabIndex = 10;
            // 
            // txtAssignment
            // 
            this.txtAssignment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAssignment.Location = new System.Drawing.Point(204, 256);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(200, 26);
            this.txtAssignment.TabIndex = 11;
            // 
            // txtModuleMark
            // 
            this.txtModuleMark.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtModuleMark.Location = new System.Drawing.Point(204, 382);
            this.txtModuleMark.Name = "txtModuleMark";
            this.txtModuleMark.ReadOnly = true;
            this.txtModuleMark.Size = new System.Drawing.Size(200, 26);
            this.txtModuleMark.TabIndex = 13;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGrade.Location = new System.Drawing.Point(204, 419);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(200, 26);
            this.txtGrade.TabIndex = 14;
            // 
            // txtFinalExam
            // 
            this.txtFinalExam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFinalExam.Location = new System.Drawing.Point(204, 288);
            this.txtFinalExam.Name = "txtFinalExam";
            this.txtFinalExam.Size = new System.Drawing.Size(200, 26);
            this.txtFinalExam.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(361, 535);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 64);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCoursework
            // 
            this.txtCoursework.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCoursework.Location = new System.Drawing.Point(204, 345);
            this.txtCoursework.Name = "txtCoursework";
            this.txtCoursework.ReadOnly = true;
            this.txtCoursework.Size = new System.Drawing.Size(200, 26);
            this.txtCoursework.TabIndex = 17;
            this.txtCoursework.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCoursework
            // 
            this.lblCoursework.AutoSize = true;
            this.lblCoursework.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoursework.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursework.Location = new System.Drawing.Point(26, 345);
            this.lblCoursework.Name = "lblCoursework";
            this.lblCoursework.Size = new System.Drawing.Size(129, 27);
            this.lblCoursework.TabIndex = 18;
            this.lblCoursework.Text = "Coursework";
            // 
            // lblCaptureMarks
            // 
            this.lblCaptureMarks.AutoSize = true;
            this.lblCaptureMarks.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptureMarks.Location = new System.Drawing.Point(200, 21);
            this.lblCaptureMarks.Name = "lblCaptureMarks";
            this.lblCaptureMarks.Size = new System.Drawing.Size(240, 45);
            this.lblCaptureMarks.TabIndex = 19;
            this.lblCaptureMarks.Text = "Capture Marks";
            // 
            // CaptureMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 654);
            this.Controls.Add(this.lblCaptureMarks);
            this.Controls.Add(this.lblCoursework);
            this.Controls.Add(this.txtCoursework);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtFinalExam);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtModuleMark);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblModuleMark);
            this.Controls.Add(this.lblFinalExam);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblStudentID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CaptureMarksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Marks";
            this.Load += new System.EventHandler(this.CaptureMarksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblFinalExam;
        private System.Windows.Forms.Label lblModuleMark;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.TextBox txtModuleMark;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtFinalExam;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCoursework;
        private System.Windows.Forms.Label lblCoursework;
        private System.Windows.Forms.Label lblCaptureMarks;
    }
}