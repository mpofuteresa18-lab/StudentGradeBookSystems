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
    public partial class ViewResultsForm : Form
    {
        public ViewResultsForm()
        {
            InitializeComponent();
        }

        private void ViewResultsForm_Load(object sender, EventArgs e)
        {
            String[] lines = File.ReadAllLines("marks.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split('#');
                dgvResults.Rows.Add(data);
                dgvResults.ReadOnly = false;

                this.Size = new Size(700, 400);
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //read all data from file
            string[] oldLines = File.ReadAllLines("marks.txt");
            string[] newLines = new string[dgvResults.Rows.Count - 1];

            for (int i = 0; i < dgvResults.Rows.Count - 1; i++)
            {
                string record = "";

                for (int j = 0; j < dgvResults.Columns.Count; j++)
                {
                    record += dgvResults.Rows[i].Cells[j].Value.ToString() + "#";
                }

                record = record.TrimEnd('#');
                newLines[i] = record;
            }

            // Checking if anything happened 
            bool isDifferent = false;

            if (oldLines.Length != newLines.Length)
            {
                isDifferent = true;
            }
            else
            {
                for (int i = 0; i < oldLines.Length; i++)
                {
                    if (oldLines[i] != newLines[i])
                    {
                        isDifferent = true;
                        break;
                    }
                }
            }

            if (isDifferent)
            {
                File.WriteAllLines("marks.txt", newLines);
                MessageBox.Show("Changes saved successfully!");
            }
            else
            {
                MessageBox.Show("No changes were made.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                dgvResults.Rows.RemoveAt(dgvResults.SelectedRows[0].Index);
                MessageBox.Show("Row deleted. Click Update to save.");
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }
    }
}
