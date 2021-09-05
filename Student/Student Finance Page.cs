using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IOOP_School_System
{
    public partial class FinanceStudentPage : Form
    {
        OleDbConnection connect = new OleDbConnection();
        public FinanceStudentPage()
        {
            InitializeComponent();
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStudentPage UP = new UpdateStudentPage();
            UP.ShowDialog();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStudentPage HP = new HomeStudentPage();
            HP.ShowDialog();
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void TableLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableStudentPage TP = new TableStudentPage();
            TP.ShowDialog();
        }

        private void FinanceStudentPage_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = University System Database.accdb";
            connect.Open();

            var display_table = new SQL()
            {
                Column_SELECT_1 = "Student.[First_Name]",
                Column_SELECT_2 = "Payment.[StudentID]",
                Column_SELECT_3 = "Payment.[PaymentID]",
                Column_SELECT_4 = "Payment.[Course_ID]",
                Column_SELECT_5 = "Payment.[Fee]",
                Column_SELECT_6 = "Payment.[Description]",
                Table = "Payment",
                Table_Join_1 = "Student",
                Column_Join_1a = "Student.[StudentID]",
                Column_Join_1b = "Payment.[StudentID]",
                Column_WHERE_1 = "Student.[StudentID]",
                String_Condition_1 = GlobalVar.UserID
            };
            display_table.Construct();
            display_table.DisplayGridTable(dataGridView_fee);
        }
    }
}
