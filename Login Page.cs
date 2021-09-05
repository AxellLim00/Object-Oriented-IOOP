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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var User = new User()
            {
                Username = UNtxt.Text,
                Password = PWtxt.Text
            };
            User.getType();
            if (User.login() == true)
            {
                if (User.Type == "Staff")
                {
                    var User_Type = new SQL()
                    {
                        Column_SELECT_1 = "StaffID",
                        Table = "Staff",
                        Column_WHERE_1 = "Username",
                        String_Condition_1 = UNtxt.Text
                    };
                    User_Type.Construct();
                    User_Type.GetData(1);
                    GlobalVar.UserID = User_Type.ResultGetData[0];

                    this.Hide();
                    MessageBox.Show("Data Identified.");
                    var home = new HomeStaffPage();
                    home.ShowDialog();
                }
                else if (User.Type == "Lecturer")
                {

                    var User_Type = new SQL()
                    {
                        Column_SELECT_1 = "LecturerID",
                        Table = "Lecturer",
                        Column_WHERE_1 = "Username",
                        String_Condition_1 = UNtxt.Text
                    };
                    User_Type.Construct();
                    User_Type.GetData(1);
                    GlobalVar.UserID = User_Type.ResultGetData[0];

                    this.Hide();
                    MessageBox.Show("Data Identified.");
                    HomeTutorPage home = new HomeTutorPage();
                    home.ShowDialog();
                }
                else if (User.Type == "Student")
                {
                    var User_Type = new SQL()
                    {
                        Column_SELECT_1 = "StudentID",
                        Table = "Student",
                        Column_WHERE_1 = "Username",
                        String_Condition_1 = UNtxt.Text
                    };
                    User_Type.Construct();
                    User_Type.GetData(1);
                    GlobalVar.UserID = User_Type.ResultGetData[0];

                    this.Hide();
                    MessageBox.Show("Data Identified.");
                    var home = new HomeStudentPage();
                    home.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("You INPUT the WRONG Username and/or Password");
            }
        }

        private void PWtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UNtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

   

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
public static class GlobalVar
{
    public static string UserID;
    public static string user;
}