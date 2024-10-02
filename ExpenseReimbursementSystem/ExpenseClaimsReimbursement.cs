using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpenseReimbursementSystem
{
    public partial class ExpenseClaimsReimbursement : Form
    {
        string claimId = "0";
        int currentRow = 0;
        string processStep = "Add";
        List<Expense> expenseList = null;
        DataTable expenseClaimTable;
        public ExpenseClaimsReimbursement()
        {
            InitializeComponent();
        }
        class Expense
        {
            public string ClaimId { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string Amount { get; set; }
            public string Date { get; set; }
            public string Status { get; set; }
        }
        private void ExpenseClaimsReimbursement_Load(object sender, EventArgs e)
        {
            defaultView();
            saveDataMenu.Enabled = false;
        }
        private void btnAddClaims_Click(object sender, EventArgs e)
        {
            repositionObjects();
            enableObjects();
            txt_claimId.Text = "";
            txt_description.Text = "";
            txt_category.Text = "";
            txt_amount.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cmb_status.SelectedIndex = 0;
            processStep = "Add";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            defaultView();
        }
        #region MENU OPTION: LOAD DATA
        private void loadDataMenu_Click(object sender, EventArgs e)
        {
            // Open file dialog to select CSV file
            expenseClaimsDataTable.Rows.Clear();
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            expenseList = new List<Expense>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string csvFilePath = openFileDialog1.FileName;
                expenseClaimTable = GetDataTableFromCSV(csvFilePath);
                foreach (DataRow row in expenseClaimTable.Rows)
                {
                    Expense expenseModel = new Expense();
                    expenseModel.ClaimId = row[0].ToString();
                    expenseModel.Description = row[1].ToString();
                    expenseModel.Category = row[2].ToString();
                    expenseModel.Amount = row[3].ToString();
                    expenseModel.Date = row[4].ToString();
                    expenseModel.Status = row[5].ToString();
                    displayData(expenseModel);
                    expenseList.Add(expenseModel);
                }
            }
            saveDataMenu.Enabled = true;
        }
        private void displayData(Expense expenseModel)
        {
            expenseClaimsDataTable.Rows.Add(expenseModel.ClaimId, expenseModel.Description, expenseModel.Category, expenseModel.Amount, expenseModel.Date, expenseModel.Status);
            expenseClaimsDataTable.Sort(expenseClaimsDataTable.Columns[0], ListSortDirection.Ascending);
        }
        private DataTable GetDataTableFromCSV(string csvFilePath)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (StreamReader sr = new StreamReader(csvFilePath))
                {
                    // Read the first line for column headers
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header); // Add columns to DataTable
                    }

                    // Read remaining lines as rows
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');

                        dataTable.Rows.Add(rows); // Add rows to DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dataTable;
        }
        #endregion

        #region MENU OPTION: SAVE DATA
        private void saveDataMenu_Click(object sender, EventArgs e)
        {
            saveDataMenuMethod();
        }
        private void saveDataMenuMethod()
        {
            // Open save file dialog
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog1.Title = "Save as CSV File";
            saveFileDialog1.FileName = Path.GetFileName(saveFileDialog1.FileName);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the file path chosen by the user
                string saveCsvFile = saveFileDialog1.FileName;
                // Export DataGridView to CSV
                ExportDataGridViewToCSV(expenseClaimsDataTable, saveCsvFile);
                MessageBox.Show("Expense claims reimbursement report has been exported.");
            }
        }
        private void ExportDataGridViewToCSV(DataGridView dgv, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write column headers
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(dgv.Columns[i].HeaderText);
                        if (i < dgv.Columns.Count - 4)
                        {
                            sw.Write(","); // Add a comma after each column except the last
                        }
                    }
                    sw.WriteLine(); // End the header line

                    // Write rows data
                    for (int i = 0; i < dgv.Rows.Count; i++) // Skip last empty row
                    {
                        for (int j = 0; j < dgv.Columns.Count - 4; j++)
                        {
                            sw.Write(dgv.Rows[i].Cells[j].Value);
                            if (j < dgv.Columns.Count - 1)
                            {
                                sw.Write(","); // Add a comma after each cell except the last
                            }
                        }
                        sw.WriteLine(); // End the row line
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        #region MENU OPTION: EXIT
        private void exitApplicationMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save before closing?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveDataMenuMethod();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
        #endregion

        #region MANAGE View, Modify, Approve & Delete
        private void expenseClaimsDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            claimId = expenseClaimsDataTable.Rows[currentRow].Cells[0].Value.ToString();
            var expenseClaimInfo = expenseList.ToList().Where(x => x.ClaimId == claimId).FirstOrDefault();
            if (currentColumnIndex == 6)
            {
                // View Expense Claims Info
                displayDataInText(expenseClaimInfo);
                disableObjects();
                repositionObjects();
                btnCancel.Show();
                btnSave.Hide();
                btnAddClaims.Show();
            }
            else if (currentColumnIndex == 7)
            {
                // Approve Expense Claims Info
                if (expenseClaimInfo.Status == "Not Approved")
                {
                    expenseClaimInfo.Status = "Approved";
                }
                else if (expenseClaimInfo.Status == "Approved")
                {
                    expenseClaimInfo.Status = "Not Approved";
                }
                else
                {
                    expenseClaimInfo.Status = "Approved";
                }
                expenseClaimsDataTable.Rows.Remove(expenseClaimsDataTable.Rows[e.RowIndex]);
                displayData(expenseClaimInfo);
            }
            else if (currentColumnIndex == 8)
            {
                // Modify Expense Claims Info
                processStep = "Modify";
                displayDataInText(expenseClaimInfo);
                repositionObjects();
                enableObjects();
            }
            else if (currentColumnIndex == 9)
            {
                // Delete or remove records
                expenseClaimsDataTable.Rows.Remove(expenseClaimsDataTable.Rows[e.RowIndex]);
                expenseList.Remove(expenseClaimInfo);
            }
        }
        private void displayDataInText(Expense expense)
        {
            txt_claimId.Text = claimId;
            txt_description.Text = expense.Description;
            txt_category.Text = expense.Category;
            txt_amount.Text = expense.Amount;
            dateTimePicker1.Value = Convert.ToDateTime(expense.Date);
            cmb_status.SelectedItem = expense.Status;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var expenseData = expenseList.ToList().Where(x => x.ClaimId == claimId).FirstOrDefault();
            if (processStep == "Add")
            {
                expenseData = new Expense();
            }
            expenseData.ClaimId = txt_claimId.Text;
            expenseData.Description = txt_description.Text;
            expenseData.Category = txt_category.Text;
            expenseData.Amount = txt_amount.Text;
            expenseData.Date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            expenseData.Status = cmb_status.SelectedItem.ToString();
            if (processStep == "Modify")
            {
                expenseClaimsDataTable.Rows.Remove(expenseClaimsDataTable.Rows[currentRow]);
            }
            else if (processStep == "Add") { expenseList.Add(expenseData); }
            displayData(expenseData);
            defaultView();
        }
        #endregion

        #region MANAGE OBJECTS
        private void defaultView()
        {
            informationEntryPanel.Hide();
            defaultTablePanel.Location = new Point(12, 13);
            defaultTablePanel.Height = 405 + 105;
            expenseClaimsDataTable.Height = 344 + 105;
            btnCancel.Hide();
            btnSave.Hide();
            btnAddClaims.Show();
        }
        private void repositionObjects()
        {
            informationEntryPanel.Show();
            defaultTablePanel.Location = new Point(12, 123);
            defaultTablePanel.Height = 405;
            expenseClaimsDataTable.Height = 344;
            btnCancel.Show();
            btnSave.Show();
            btnAddClaims.Hide();
        }
        private void enableObjects()
        {
            txt_claimId.Enabled = true;
            txt_description.Enabled = true;
            txt_category.Enabled = true;
            txt_amount.Enabled = true;
            dateTimePicker1.Enabled = true;
            cmb_status.Enabled = true;
        }
        private void disableObjects()
        {
            txt_claimId.Enabled = false;
            txt_description.Enabled = false;
            txt_category.Enabled = false;
            txt_amount.Enabled = false;
            dateTimePicker1.Enabled = false;
            cmb_status.Enabled = false;
        }
        #endregion

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            try
            {
                foreach (DataGridViewRow row in expenseClaimsDataTable.Rows)
                {
                    bool isVisible = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue.ToLower()))
                        {
                            isVisible = true;
                            break;
                        }
                    }

                    row.Visible = isVisible;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txt_claimId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
