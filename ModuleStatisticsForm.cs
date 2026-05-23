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
    public partial class ModuleStatisticsForm : Form
    {
        public ModuleStatisticsForm()
        {
            InitializeComponent();
        }

        private void ModuleStatisticsForm_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("marks.txt");

            int total = lines.Length;
            double sum = 0;
            double highest = 0;
            double lowest = 100;
            int passCount = 0;
            //calculating the statistics

            foreach (string line in lines)
            {
                string[] parts = line.Split('#');

                double moduleMark = double.Parse(parts[4]);

                sum += moduleMark;

                if (moduleMark > highest)
                    highest = moduleMark;

                if (moduleMark < lowest)
                    lowest = moduleMark;

                if (moduleMark >= 50)
                    passCount++;
            }

            double average = sum / total;
            double passRate = (passCount * 100.0) / total;

            // Display results
            lblTotal.Text = total.ToString();
            lblAverage.Text = average.ToString("0.00");
            lblHighest.Text = highest.ToString();
            lblLowest.Text = lowest.ToString();
            lblPassRate.Text = passRate.ToString("0.00") + "%";

            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
