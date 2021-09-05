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
    public partial class CourseStaffPage : Form
    {
        OleDbConnection connect = new OleDbConnection();
        
        public CourseStaffPage()
        {
            InitializeComponent();
        }

        private void RegisterStudentLabel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegisterStaffPage rsp = new RegisterStaffPage();
            rsp.ShowDialog();
        }

        private void FeePaymentLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeeStaffPage fsp = new FeeStaffPage();
            fsp.ShowDialog();
        }

        private void HomeLabel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeStaffPage hsp = new HomeStaffPage();
            hsp.ShowDialog();
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBox_id.Text;

            var display_course = new SQL()
            {
                Column_SELECT_1 = "Student.[First_Name] as Full_Name",
                Column_SELECT_2 = "Enroll.[EnrollID]",
                Column_SELECT_3 = "Course.[Course_Name]",
                Table = "Student",
                Table_Join_1 = "Enroll",
                Column_Join_1a = "Student.[StudentID]",
                Column_Join_1b = "Enroll.[StudentID]",
                Table_Join_2 = "Course",
                Column_Join_2a = "Course.[CourseID]",
                Column_Join_2b = "Enroll.[CourseID]",
                Column_WHERE_1 = "Enroll.[StudentID]",
                String_Condition_1 = id
            };
            display_course.Construct();
            display_course.DisplayGridTable(dataGridView_course);
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void dataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseStaffPage_Load(object sender, EventArgs e)
        {

            var id = new SQL()
            {
                Column_SELECT_1 = "StudentID",
                Table = "Student",
            };
            id.Construct();
            id.FillComboBox(comboBox_id);

            var course = new SQL()
            {
                Column_SELECT_1 = "Course_Name",
                Table = "Course",
            };
            course.Construct();
            course.FillComboBox(comboBox_course);
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_check_Click(object sender, EventArgs e)

        {
            var cmdcourse = new SQL()
            {
                Column_SELECT_1 = "Count (EnrollID)",
                Table = "Enroll",
            };
            cmdcourse.Construct();
            int enrollamount = 0;
            cmdcourse.GetData(1);
            enrollamount = int.Parse(cmdcourse.ResultGetData[0].ToString());
            enrollamount = enrollamount + 1;
            textBox_enrollid.Text = "E0" + enrollamount;

            string user = comboBox_course.Text;

            var display_id = new SQL()
            {
                Column_SELECT_1 = "CourseID",
                Table = "Course",
                Column_WHERE_1 = "Course_Name",
                String_Condition_1 = user
            };
            display_id.Construct();
            if (display_id.Read() == true)
            {
                display_id.GetData(1);
                textBox_course.Text = display_id.ResultGetData[0].ToString();
            }
            else
            {
                MessageBox.Show("Error.");
            }

            var display_list = new SQL()
            {
                Column_SELECT_1 = "Fee",
                Table = "Course",
                Column_WHERE_1 = "Course_Name",
                String_Condition_1 = comboBox_course.Text
            };
            display_list.Construct();
            if (display_list.Read() == true)
            {
                display_list.GetData(1);
                textBox_fee.Text = display_list.ResultGetData[0].ToString();
            }
            else
            {
                MessageBox.Show("Error.");
            }

            var display_list1 = new SQL()
            {
                Column_SELECT_1 = "Day_of_week",
                Table = "Course",
                Column_WHERE_1 = "Course_Name",
                String_Condition_1 = comboBox_course.Text
            };
            display_list1.Construct();
            if (display_list1.Read() == true)
            {
                display_list1.GetData(1);
                textBox_day.Text = display_list1.ResultGetData[0].ToString();
            }
            else
            {
                MessageBox.Show("Error.");
            }

            var display_list2 = new SQL()
            {
                Column_SELECT_1 = "Duration",
                Table = "Course",
                Column_WHERE_1 = "Course_Name",
                String_Condition_1 = comboBox_course.Text
            };
            display_list2.Construct();
            if (display_list2.Read() == true)
            {
                display_list2.GetData(1);
                textBox_duration.Text = display_list2.ResultGetData[0].ToString();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var cmdstudent = new SQL()
            {
                Column_SELECT_1 = "Count(StudentID)",
                Table = "Enroll",
                Column_WHERE_1 = "CourseID",
                String_Condition_1 = textBox_course.Text
            };
            cmdstudent.Construct();
            int student = 0;
            cmdstudent.GetData(1);
            student = int.Parse(cmdstudent.ResultGetData[0].ToString());
            
            if (student < 25)
            {
                var addlist = new SQL()
                {
                    Table = "Enroll",
                    Column_INSERT_1 = "EnrollID",
                    Column_INSERT_2 = "StudentID",
                    Column_INSERT_3 = "CourseID",
                    String_insert_1 = textBox_enrollid.Text,
                    String_insert_2 = comboBox_id.Text,
                    String_insert_3 = textBox_course.Text
                };
                addlist.Construct();
                if (addlist.Insert() == true)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
                MessageBox.Show("Class is Full, Enrollment Failed ! Please select another class.");




        }

        private void textBox_enrollid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            string id = comboBox_id.Text;

            var display_course = new SQL()
            {
                Column_SELECT_1 = "Student.[First_Name] as Full_Name",
                Column_SELECT_2 = "Enroll.[EnrollID]",
                Column_SELECT_3 = "Course.[Course_Name]",
                Table = "Student",
                Table_Join_1 = "Enroll",
                Column_Join_1a = "Student.[StudentID]",
                Column_Join_1b = "Enroll.[StudentID]",
                Table_Join_2 = "Course",
                Column_Join_2a = "Course.[CourseID]",
                Column_Join_2b = "Enroll.[CourseID]",
                Column_WHERE_1 = "Enroll.[StudentID]",
                String_Condition_1 = id
            };
            display_course.Construct();
            display_course.DisplayGridTable(dataGridView_course);
        }
    }
}
