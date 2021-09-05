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
    public partial class RegisterStaffPage : Form
    {
        OleDbConnection connect = new OleDbConnection();
        public RegisterStaffPage()
        {
            InitializeComponent();
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void FeePaymentLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeeStaffPage fsp = new FeeStaffPage();
            fsp.ShowDialog();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStaffPage hsp = new HomeStaffPage();
            hsp.ShowDialog();
        }

        private void RegisterStudentLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void CourseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseStaffPage csp = new CourseStaffPage();
            csp.ShowDialog();
        }

        private void RegisterStaffPage_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_check_Click(object sender, EventArgs e)
        {
            string date = System.DateTime.Today.ToString("MM/dd/yyyy");
            label_date.Text = date;

            var cmdstudent = new SQL()
            {
                Column_SELECT_1 = "Count(StudentID)",
                Table = "Student"
            };
            cmdstudent.Construct();
            int student = 0;
            cmdstudent.GetData(1);
            student = int.Parse(cmdstudent.ResultGetData[0].ToString());
            student = student + 1;
            textBox_StudentID.Text = "ST0" + student;

            var cmduser = new SQL()
            {
                Column_SELECT_1 = "Count(Username)",
                Table = "Login"
            };
            cmduser.Construct();
            int user = 0;
            cmduser.GetData(1);
            user = int.Parse(cmduser.ResultGetData[0].ToString());
            user = student + 1;
            textBox_user.Text = "Student" + student;
            textBox_pass.Text = "student";



        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            var addst = new SQL()
            {
                Table = "Student",
                Column_INSERT_1 = "StudentID",
                Column_INSERT_2 = "First_Name",
                Column_INSERT_3 = "Last_Name",
                Column_INSERT_4 = "Date_of_Birth",
                Column_INSERT_5 = "Contact_Number",
                Column_INSERT_6 = "Email",
                Column_INSERT_7 = "Address",
                Column_INSERT_8 = "Username",
                String_insert_1 = textBox_StudentID.Text,
                String_insert_2 = textBox_firstname.Text,
                String_insert_3 = textBox_lastname.Text,
                String_insert_4 = pickerdob.Text,
                String_insert_5 = textBox_contact.Text,
                String_insert_6 = textBox_email.Text,
                String_insert_7 = textBox_address.Text,
                String_insert_8 = textBox_user.Text,
            };
            addst.Construct();

            var addidpass = new SQL()
            {
                Table = "Login",
                Column_INSERT_1 = "[Username]",
                Column_INSERT_2 = "[Password]",
                Column_INSERT_3 = "[User_Type]",
                String_insert_1 = textBox_user.Text,
                String_insert_2 = textBox_pass.Text,
                String_insert_3 = "Student"
            };
            addidpass.Construct();

            if (addst.Insert() == true && addidpass.Insert() == true)
            {
                MessageBox.Show("Registered Successfully");
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void label_date_Click(object sender, EventArgs e)
        {

        }

        private void idlabel_Click(object sender, EventArgs e)
        {

        }
    }


    }


