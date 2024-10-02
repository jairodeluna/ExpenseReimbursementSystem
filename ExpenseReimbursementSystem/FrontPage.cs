using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            timer1.Start();
            timer1.Interval = 2000;
            progressBar1.Value = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                ExpenseClaimsReimbursement expenseClaimsReimbursement = new ExpenseClaimsReimbursement();
                expenseClaimsReimbursement.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
