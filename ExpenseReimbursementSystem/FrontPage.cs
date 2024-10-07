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

namespace ExpenseReimbursementSystem
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup a timer for progress bar to be active
            timer1.Start();
            // Set the interval into 2 seconds (2000 = 2)
            timer1.Interval = 2000;
            progressBar1.Value = 100;

            // Create a folder in C drive.
            string filePath = "C:\\ExpenseClaims\\";
            if (!File.Exists(filePath))
            {
                // If there is no existing folder, create new
                Directory.CreateDirectory(filePath);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Setup the event for the timer every time its tick and increment by 1
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                // Prepare and open the dashboard
                ExpenseClaimsReimbursement expenseClaimsReimbursement = new ExpenseClaimsReimbursement();
                expenseClaimsReimbursement.Show();

                // Hide this FrontPage form
                this.Hide();
                
                // Stop the timer
                timer1.Stop();
            }
        }
    }
}
