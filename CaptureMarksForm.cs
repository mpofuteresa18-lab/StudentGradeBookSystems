using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentGradeBookSystems
{
    public partial class CaptureMarksForm : Form
    {
        private object txtFinaleExam;

        public CaptureMarksForm()
        {
            InitializeComponent();
        }

        private void ttxTest_Click(object sender, EventArgs e)
        {

        }

        private void txtFinaleExam_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentID_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                int test = int.Parse(txtTest.Text);
                int assignment=int.Parse(txtAssignment.Text);
                int finalExam = int.Parse(txtFinalExam.Text);


                Student s =new Student();
                s.StudentID = txtStudentID.Text;
                s.Module=cmbModule.Text;
                s.Test = int.Parse(txtTest.Text);
                s.Assignment = int.Parse(txtAssignment.Text);
                s.FinalExam = int.Parse(txtFinalExam.Text);

                //Calling the methods
                double moduleMark = s.CalculateModuleMark();
                s.CalculateGrade();
                string Grade = s.CalculateGrade();
                txtGrade.Text = s.Grade;
                txtCoursework.Text = s.Coursework.ToString();






                //Displaying the grade
                txtModuleMark.Text = moduleMark.ToString();

                txtGrade.Text=Grade; 
                
                string studentID = txtStudentID.Text;
                string module = cmbModule.Text;

                string record = s.StudentID + "#" + s.Module + "#" + s.Test + "#" +
                                s.Assignment + "#" + s.FinalExam + "#" +
                                s.moduleMark + "#" + s.Grade;

                File.AppendAllText("marks.txt", record + Environment.NewLine);

                MessageBox.Show("Saved Succcesfully!");
                txtStudentID.Clear();
                txtTest.Clear();
                txtAssignment.Clear();
                txtFinalExam.Clear();
                txtCoursework.Clear();
                txtModuleMark.Clear();
                txtGrade.Clear();
                cmbModule.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error: Please enter valid numbers");
                   
                }

            }
        }

        private void CaptureMarksForm_Load(object sender, EventArgs e)
        {
            cmbModule.Items.Add("ABC104");
            cmbModule.Items.Add("CSE105");
            cmbModule.Items.Add("CSE103");


            cmbModule.SelectedIndex = 0;
            cmbModule.DropDownStyle= ComboBoxStyle.DropDownList;

            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
