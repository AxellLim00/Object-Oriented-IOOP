using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_School_System
{
    public partial class FeeStaffPage : Form
    {
        public void hidePanels()
        {
            panelreceipt.Visible = false;
        }

        public FeeStaffPage()
        {
            InitializeComponent();
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void RegisterStudentLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterStaffPage rsp = new RegisterStaffPage();
            rsp.ShowDialog();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStaffPage hsp = new HomeStaffPage();
            hsp.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseStaffPage csp = new CourseStaffPage();
            csp.ShowDialog();
        }

        private void dataGridView_fee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_check_Click(object sender, EventArgs e)
        {
            var display_table = new SQL()
            {
                Column_SELECT_1 = "Payment.[PaymentID]",
                Column_SELECT_2 = "Payment.[Fee]",
                Column_SELECT_3 = "Payment.[Description]",
                Table = "Payment",
                Table_Join_1 = "Student",
                Column_Join_1a = "Student.[StudentID]",
                Column_Join_1b = "Payment.[StudentID]",
                Column_WHERE_1 = "Student.StudentID",
                String_Condition_1 = comboBox_fee.Text
            };
            display_table.Construct();
            display_table.DisplayGridTable(dataGridView_fee);
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Change_Name = new SQL()
            {
                Column_SELECT_1 = "First_Name",
                Table = "Student",
                Column_WHERE_1 = "StudentID",
                String_Condition_1 = comboBox_fee.Text
            };
            Change_Name.Construct();
            if (Change_Name.Read() == true)
            {
                Change_Name.GetData(1);
                textBox_name.Text = Change_Name.ResultGetData[0].ToString();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void FeeStaffPage_Load(object sender, EventArgs e)
        {
            hidePanels();

            var FillID = new SQL()
            {
                Column_SELECT_1 = "StudentID",
                Table = "Student"
            };
            FillID.Construct();
            FillID.FillComboBox(comboBox_fee);
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            string status = "Unpaid";

            var check = new SQL()
            {
                Column_SELECT_1 = "Description",
                Table = "Payment",
                Column_WHERE_1 = "PaymentID",
                String_Condition_1 = textBox_paymentid.Text
            };
            check.Construct();
            check.GetData(1);
            status = check.ResultGetData[0];

            if (status != "Paid")
            {
                hidePanels();
                panelreceipt.Visible = true;

                var paidlist = new SQL()
                {
                    String_update_1 = "Paid",
                    Column_UPDATE_1 = "Description",
                    Table = "Payment",
                    Column_WHERE_1 = "PaymentID",
                    String_Condition_1 = textBox_paymentid.Text
                };
                paidlist.Construct();
                paidlist.Update();
                try
                {
                    panelreceipt.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Unsuccessful, This has already been PAID");
            }

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            var display_fee2 = new SQL()
            {
                Column_SELECT_1 = "Payment.[PaymentID]",
                Column_SELECT_2 = "Payment.[Fee]",
                Column_SELECT_3 = "Payment.[Description]",
                Table = "Payment",
                Table_Join_1 = "Student",
                Column_Join_1a = "Student.[StudentID]",
                Column_Join_1b = "Payment.[StudentID]"
            };
            display_fee2.Construct();
            display_fee2.DisplayGridTable(dataGridView_fee);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            {
                labelidnew.Text = comboBox_fee.Text;
                labelpaymentnew.Text = textBox_paymentid.Text;

                var display_pay = new SQL()
                {
                    Column_SELECT_1 = "Fee",
                    Table = "Payment",
                    Column_WHERE_1 = "PaymentID",
                    String_Condition_1 = textBox_paymentid.Text,
                };
                display_pay.Construct();
                display_pay.GetData(1);
                labeltotalnew.Text = display_pay.ResultGetData[0].ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelreceipt.Visible = false;
        }
    }
}
