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
    public partial class UpdateStudentPage : Form
    {
        public UpdateStudentPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStudentPage HP = new HomeStudentPage();
            HP.ShowDialog();
        }

        private void FinanceLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinanceStudentPage FP = new FinanceStudentPage();
            FP.ShowDialog();
        }

        private void TableLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableStudentPage TP = new TableStudentPage();
            TP.ShowDialog();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var update = new SQL()
            {
                Column_WHERE_1 = "StudentID",
                String_Condition_1 = GlobalVar.UserID,
                Table = "Student",
            };

            if (comboBox_InfoList.Text == "Personal Email")
            {
                update.Column_UPDATE_1 = "Email";
                update.String_update_1 = Informationtxt.Text;
            }
            else if (comboBox_InfoList.Text == "Home Address")
            {
                update.Column_UPDATE_1 = "Address";
                update.String_update_1 = Informationtxt.Text;
            }
            else if (comboBox_InfoList.Text == "Contact Number")
            {
                update.Column_UPDATE_1 = "Contact_Number";
                update.String_update_1 = Informationtxt.Text;
            }
            update.Construct();
            
            if (update.Update() == true)
            {
                MessageBox.Show("Update Successful");
            }
            else
            {
                MessageBox.Show("Update Failed, Data Invalid");
            }
        }

        private void button_SeeChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStudentPage HP = new HomeStudentPage();
            HP.ShowDialog();
        }

        private void UpdateStudentPage_Load(object sender, EventArgs e)
        {

        }
    }
}
