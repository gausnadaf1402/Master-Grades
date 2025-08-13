using MstGrades.Models;
using MstGrades.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MstGrades
{
    public partial class FrmGrademanager : Form
    {
        private readonly IGradeRepository _GradeRepo; // Repository for grade data
        const int showLeftPos = 367; // Position where the grid view panel should be shown
        private int selectedGradeID = -1; // Default value indicating no selection

        public FrmGrademanager()
        {
            InitializeComponent();
            _GradeRepo = new SqlGradeRespository(); // Initialize the grade repository

            dataGridView1.ReadOnly = true; // Make DataGridView read-only
            dataGridView1.RowHeadersVisible = false; // Hide row headers
            dataGridView1.AllowUserToAddRows = false; // Disable adding new rows
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full rows
            dataGridView1.MultiSelect = true; // Allow multiple row selection
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete; // Handle DataBindingComplete event
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged; // Handle SelectionChanged event to update the selected row

            cmbdvRight.Items.Add("GradeName");
            cmbdvRight.Items.Add("Description");
            cmbdvRight.SelectedIndex = 0; // Set default selected item
            txtGridSearch.TextChanged += txtGridSearch_TextChanged; // Handle text changed event for search functionality
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showGrid();
            btnHide.Enabled = true;
            btnShow.Enabled = false;
            var dt = _GradeRepo.GetAll();
            dataGridView1.DataSource = dt;
        }

        public void showGrid()
        {
            while (gvpanel.Left > showLeftPos)
            {
                gvpanel.Left = gvpanel.Left - 10;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            HideGrid();
            btnHide.Enabled = false;
            btnShow.Enabled = true;
        }

        public void HideGrid()
        {
            while (gvpanel.Left < MainPanel.Width + 20)
            {
                gvpanel.Left = gvpanel.Left + 10;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaskmanager_Load(object sender, EventArgs e)
        {

            var dt = _GradeRepo.GetAll();
            dataGridView1.DataSource = dt;

            // hide all the columns
            dataGridView1.Columns["createdby"].Visible = false;
            dataGridView1.Columns["createddate"].Visible = false;
            dataGridView1.Columns["modifiedby"].Visible = false;
            dataGridView1.Columns["modifieddate"].Visible = false;
            dataGridView1.Columns["IsDeleted"].Visible = false;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SelectLastRealRow();
        }

        private void SelectLastRealRow()
        {
            if (dataGridView1.Rows.Count == 0) return;

            int lastIndex = dataGridView1.Rows.Count - 1;

            // If the last row is the placeholder new row, step back
            if (dataGridView1.AllowUserToAddRows && dataGridView1.Rows[lastIndex].IsNewRow)
            {
                lastIndex--;
            }

            if (lastIndex < 0) return;

            dataGridView1.ClearSelection();
            dataGridView1.Rows[lastIndex].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = lastIndex;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            var row = dataGridView1.SelectedRows[0];
            if (row.Cells["GradeID"].Value == null)
                return;

            selectedGradeID = Convert.ToInt32(row.Cells["GradeID"].Value);
            //txtgradeid.Text = selectedGradeID.ToString();
            txtgradename.Text = row.Cells["GradeName"].Value?.ToString() ?? string.Empty;
            txtdescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
            checkboxactivestatus.Checked = Convert.ToBoolean(row.Cells["ActiveStatus"].Value);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtgradename.Text))
            {
                MessageBox.Show("Grade Name is required.");
                return;
            }

            var grade = new Grade
            {
                GradeName = txtgradename.Text.Trim(),
                Description = txtdescription.Text.Trim(),
                ActiveStatus = checkboxactivestatus.Checked,
            };

            try
            {
                _GradeRepo.AddGrade(grade);
                MessageBox.Show("Record added successfully.");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtgradeid.Clear();
            txtgradename.Clear();
            txtdescription.Clear();
            checkboxactivestatus.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedGradeID < 0)
            {
                MessageBox.Show("Please select a grade to edit.");
                return;
            }

            var grade = new Grade
            {
                GradeID = selectedGradeID,
                GradeName = txtgradename.Text.Trim(),
                Description = txtdescription.Text.Trim(),
                ActiveStatus = checkboxactivestatus.Checked,
            };
            try
            {
                _GradeRepo.UpdateGrade(grade);
                MessageBox.Show("Record updated successfully.");
                ClearForm();
                selectedGradeID = -1; // Reset the selected ID
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedGradeID < 0)
            {
                MessageBox.Show("Please select a grade to delete.");
                return;
            }

            try
            {
                _GradeRepo.DeleteGrade(selectedGradeID);
                MessageBox.Show("Record deleted successfully.");
                ClearForm();
                selectedGradeID = -1; // Reset selected ID
                //LoadGrades(); // Refresh the grid after deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtGridSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
            {
                string filterColumn = cmbdvRight.SelectedItem.ToString();
                string searchValue = txtGridSearch.Text.Replace("'","' '"); // Escape single quotes for SQL-like filtering
                if (!string.IsNullOrEmpty(searchValue))
                {
                    dt.DefaultView.RowFilter = $"{filterColumn} LIKE '%{searchValue}%'";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Empty; // Clear filter if search text is empty
                }
            }
        }
    }
}
