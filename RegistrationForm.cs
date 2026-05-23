using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeBookSystems
{
    public partial class RegistrationForm : Form
    {
        private string firstname;
        private string cellno;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string staffid = txtStaffID.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string firstaname = txtFirstName.Text;
                string surname = txtSurname.Text;
                string gender = cmbGender.Text;
                string position = cmbPosition.Text;
                string dateregistered = dtpDateRegistered.Text;

                if (staffid == "" || email == "" || password == "" ||
            firstname == "" || surname == "" || cellno == "" ||
            gender == "" || position == "")
                {
                    MessageBox.Show("Please fill in all fields!");
                    return;
                }


                string record = staffid + "#+email+ #" + password + "#" + firstaname + "#" + surname + "#" + gender + "#" + lblCellNo + "#" + position + "#" + dateregistered;

                File.AppendAllText("users.txt", record + Environment.NewLine);

                MessageBox.Show("Registration Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }


       }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;

        }
    }



}
 