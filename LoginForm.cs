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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked)
            { // shows password
                txtPassword.UseSystemPasswordChar = false; 
            }
            else
            {// hides password
                txtPassword.UseSystemPasswordChar= true;
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                string[] lines = File.ReadAllLines("users.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split('#');
                    if (email == parts[1] && password == parts[2])
                    {
                        DashBoardForm dashBoardForm = new DashBoardForm();
                        dashBoardForm.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Invalid email or password");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " + ex.Message);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }
    }

}
