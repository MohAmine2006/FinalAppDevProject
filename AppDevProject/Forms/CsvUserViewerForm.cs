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

namespace AppDevProject.Forms
{
    public partial class CsvUserViewerForm : Form
    {
        private List<string[]> records = new List<string[]>();
        private int currentIndex = 0; // -1 if no record allowed immediate file open

        public CsvUserViewerForm()
        {
            InitializeComponent();
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            // basic styling – you can tweak as you like
            this.Text = "User Record Viewer";

            this.BackColor = System.Drawing.Color.FromArgb(233, 255, 244);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "TXT files (*.txt)|*.txt"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    records.Clear();
                    string[] lines = File.ReadAllLines(ofd.FileName);

                    // Skip header row
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] cols = lines[i].Split(',');
                        records.Add(cols);
                    }

                    //currentIndex = -1; // -1 if no record allowed immediate file open

                    if (records.Count > 0)
                    {
                        currentIndex = 0;
                        ShowRecord(currentIndex);
                    }
                    else
                    {
                        MessageBox.Show("No records found in the file.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("File loaded! Click Next or Previous to view records", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnNextRecord_Click(object sender, EventArgs e)
        {
            if (records.Count == 0) return;

            currentIndex++;
            if (currentIndex >= records.Count)
            {
                //MessageBox.Show("No more records.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentIndex = 0;
                //return;
            }

            ShowRecord(currentIndex);
        }

        private void btnPrevRecord_Click(object sender, EventArgs e)
        {
            if (records.Count == 0) return;

            currentIndex--;
            if (currentIndex < 0)
            {
                //MessageBox.Show("Already at the first record.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentIndex = records.Count - 1;
                //return;
            }

            ShowRecord(currentIndex);
        }

        // Show 6 columns
        private void ShowRecord(int index)
        {
            if (index < 0 || index >= records.Count) return;

            txtUserID.Text = records[index].Length > 0 ? records[index][0] : "";
            txtUsername.Text = records[index].Length > 1 ? records[index][1] : "";
            txtPassword.Text = records[index].Length > 2 ? records[index][2] : "";
            txtFirstName.Text = records[index].Length > 3 ? records[index][3] : "";
            txtLastName.Text = records[index].Length > 4 ? records[index][4] : "";
            txtPhone.Text = records[index].Length > 5 ? records[index][5] : "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CsvUserViewerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
