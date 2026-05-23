using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeBookSystems
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
            
        }

        private void btnCaptureMarksForm_Click(object sender, EventArgs e)
        {
            CaptureMarksForm cm = new CaptureMarksForm();
          cm.Show();

        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            ViewResultsForm vr = new ViewResultsForm();
            vr.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Return user to login form
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            ModuleStatisticsForm stats = new ModuleStatisticsForm();
            stats.Show();
         }
    }
}
