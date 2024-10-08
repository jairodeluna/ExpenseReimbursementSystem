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
        // Declare variable to access everywhere in the code
        int claimId = 0;
        int currentRow = 0;
        string processStep = "Add";
        List<Expense> expenseList = null;
        DataTable expenseClaimTable;
        public ExpenseClaimsReimbursement()
        {
            InitializeComponent();
        }

        // Create a model to hold the data from the import
        class Expense
        {
            public int ClaimId { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public int Amount { get; set; }
            public DateTime Date { get; set; }
            public string Status { get; set; }
        }
        private void ExpenseClaimsReimbursement_Load(object sender, EventArgs e)
        {
            // Load page: display what the user will see
            defaultView();
            saveDataMenu.Enabled = false;
        }
        private void btnAddClaims_Click(object sender, EventArgs e)
        {
            // Reposition Objects as datagrid on top 
            repositionObjects();
            // enable objects from being disabled to acess
            enableObjects();

            // Set the textboxes or user input into empty/default
            txt_claimId.Text = "";
            txt_description.Text = "";
            txt_category.Text = "";
            txt_amount.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cmb_status.SelectedIndex = 1;

            // Inform the sytem that Addition process has been made
            processStep = "Add";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Revert back the view into default 
            defaultView();
        }
        #region MENU OPTION: LOAD DATA
        private void loadDataMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Refresh the content of the table into new
                expenseClaimsDataTable.Rows.Clear();
                // Open save file dialog and filter by CSV file only
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";

                // Initialize a list for storing number of rows
                expenseList = new List<Expense>();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = openFileDialog1.FileName;
                    expenseClaimTable = GetDataTableFromCSV(csvFilePath);
                    foreach (DataRow row in expenseClaimTable.Rows)
                    {
                        // Get each value from CSV file per column and store into list model
                        Expense expenseModel = new Expense();
                        expenseModel.ClaimId = Convert.ToInt32(row[0].ToString());
                        expenseModel.Description = row[1].ToString();
                        expenseModel.Category = row[2].ToString();
                        expenseModel.Amount = Convert.ToInt32(row[3].ToString());
                        expenseModel.Date = Convert.ToDateTime(row[4].ToString());
                        expenseModel.Status = row[5].ToString();

                        // Pass the value to the method using the model
                        displayData(expenseModel);

                        // Add a row in the list
                        expenseList.Add(expenseModel);
                    }
                }

                // Since data exist in the table, enable now the save button to allow the user to save or export report.
                saveDataMenu.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void displayData(Expense expenseModel)
        {
            // Add the retrieve data in the datagridview
            expenseClaimsDataTable.Rows.Add(expenseModel.ClaimId, expenseModel.Description, expenseModel.Category, expenseModel.Amount, expenseModel.Date.ToString("MM/dd/yyyy"), expenseModel.Status);
            // Sort the rows based on claim Id
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        #endregion

        #region MENU OPTION: SAVE DATA
        private void saveDataMenu_Click(object sender, EventArgs e)
        {
            // Perform the method after click
            saveDataMenuMethod();
        }
        private void saveDataMenuMethod()
        {
            // Open save file dialog and filter by CSV file only
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog1.Title = "Save as CSV File";

            // Display the filename not the whole directory
            saveFileDialog1.FileName = Path.GetFileName(saveFileDialog1.FileName);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the file path chosen by the user
                string saveCsvFile = saveFileDialog1.FileName;
                // Export DataGridView to CSV
                ExportDataGridViewToCSV(expenseClaimsDataTable, saveCsvFile);
                MessageBox.Show("Expense claims reimbursement report has been exported", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region MENU OPTION: EXIT
        private void exitApplicationMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save before closing?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                // Create and place the csv file in c drive for saving the report automatically.
                string filePathTemp = "C:\\ExpenseClaims\\";
                string fileName = "ExpenseClaims-" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                var fileStream = File.Create(filePathTemp + fileName);
                // Set or mark the file as close the prevent from "used another process" error
                fileStream.Close();

                // Perform the auto save by passing the data from datagridview and the location of where the file will be save.
                ExportDataGridViewToCSV(expenseClaimsDataTable, filePathTemp + fileName);
                Application.Exit();
            }
            else
            {
                // Perform application exit if choose "No"
                Application.Exit();
            }
        }
        #endregion

        #region MANAGE View, Modify, Approve & Delete
        private void expenseClaimsDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Store the selected row index
                currentRow = int.Parse(e.RowIndex.ToString());
                // Get the column index position
                int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
                // Get the claim Id based on selected row index
                claimId = Convert.ToInt32(expenseClaimsDataTable.Rows[currentRow].Cells[0].Value.ToString());
                // Retrieve the data based on claim Id (row index selected)
                var expenseClaimInfo = expenseList.ToList().Where(x => x.ClaimId == claimId).FirstOrDefault();

                if (currentColumnIndex == 6)
                {
                    // View Expense Claims Info
                    displayDataInText(expenseClaimInfo);

                    // Position and disable objects after clicking view
                    disableObjects();
                    repositionObjects();
                    
                    btnCancel.Show();
                    btnSave.Hide();
                    btnAddClaims.Show();
                }
                else if (currentColumnIndex == 7)
                {
                    // Approve Expense Claims Info
                    if (expenseClaimInfo.Status == "Not Approve")
                    {
                        expenseClaimInfo.Status = "Approved";
                    }
                    else if (expenseClaimInfo.Status == "Approved")
                    {
                        expenseClaimInfo.Status = "Not Approve";
                    }
                    else
                    {
                        // If "Approved" & "Not Approve" is not present, set the status into default
                        expenseClaimInfo.Status = "Approved";
                    }
                    // Refresh the table by removing edited row
                    expenseClaimsDataTable.Rows.Remove(expenseClaimsDataTable.Rows[e.RowIndex]);
                    // Replace with the new edited row
                    displayData(expenseClaimInfo);
                }
                else if (currentColumnIndex == 8)
                {
                    // Modify Expense Claims Info
                    processStep = "Modify";

                    // Display the value in the table into the textboxes
                    displayDataInText(expenseClaimInfo);

                    // Position and enable objects after clicking view
                    repositionObjects();
                    enableObjects();
                }
                else if (currentColumnIndex == 9)
                {
                    // Delete or remove records
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Remove the deleted row in the datagridview
                        expenseClaimsDataTable.Rows.Remove(expenseClaimsDataTable.Rows[e.RowIndex]);
                        // Remove the deleted row in the model list
                        expenseList.Remove(expenseClaimInfo);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void displayDataInText(Expense expense)
        {
            // Display the data in the textboxes based on selected row in the datagridview
            txt_claimId.Text = claimId.ToString();
            txt_description.Text = expense.Description;
            txt_category.Text = expense.Category;
            txt_amount.Text = expense.Amount.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(expense.Date);
            cmb_status.SelectedItem = expense.Status;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the data based on claim Id (row index selected)
                var expenseData = expenseList.ToList().Where(x => x.ClaimId == claimId).FirstOrDefault();
                if (processStep == "Add")
                {
                    // Add validation when adding data if claim Id already exist as unique identifier
                    var verifyData = expenseList.ToList().Where(x => x.ClaimId == Convert.ToInt32(txt_claimId.Text)).FirstOrDefault();
                    if (verifyData != null)
                    {
                        // force an exception to warning the user
                        throw new Exception("Claim Id exist already.");
                    }
                    // Retrieve as new data once process is addition
                    expenseData = new Expense();
                }

                // Retrieve data based on the input from textboxes & etc.

                expenseData.ClaimId = Convert.ToInt32(txt_claimId.Text);
                expenseData.Description = txt_description.Text;
                expenseData.Category = txt_category.Text;
                expenseData.Amount = Convert.ToInt32(txt_amount.Text);
                expenseData.Date = Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                expenseData.Status = cmb_status.SelectedItem.ToString();

                if (processStep == "Modify")
                {
                    // Remove the edited row to perform refresh
                    expenseClaimsDataTable.Rows.Remove(expenseClaimsDataTable.Rows[currentRow]);
                }
                else if (processStep == "Add") 
                { 
                    // Store the new data into the list
                    expenseList.Add(expenseData); 
                }

                // Retrieve the edited version of the row
                displayData(expenseData);
                // Set the objects into default view
                defaultView();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region MANAGE OBJECTS
        private void defaultView()
        {
            // Hide, show, manage size and reposition objects
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
            // Hide, show, manage size and reposition objects
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
            // enable the disabled objects
            txt_claimId.Enabled = true;
            txt_description.Enabled = true;
            txt_category.Enabled = true;
            txt_amount.Enabled = true;
            dateTimePicker1.Enabled = true;
            cmb_status.Enabled = true;
        }
        private void disableObjects()
        {
            // disable the enabled objects
            txt_claimId.Enabled = false;
            txt_description.Enabled = false;
            txt_category.Enabled = false;
            txt_amount.Enabled = false;
            dateTimePicker1.Enabled = false;
            cmb_status.Enabled = false;
        }
        #endregion

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            try
            {
                // Retrieve all the rows
                foreach (DataGridViewRow row in expenseClaimsDataTable.Rows)
                {
                    bool isVisible = false;

                    // Based on the row, retrieve each value in the cell
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // set the value in to lower case to get the exact word
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue.ToLower()))
                        {
                            // Set the row into visible and hide the rows which not in search category
                            isVisible = true;
                            break;
                        }
                    }

                    row.Visible = isVisible;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_claimId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent the text box in accepting letters
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent the text box in accepting letters
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
