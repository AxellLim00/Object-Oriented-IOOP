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
    public partial class StudentTutorPage : Form
    {
        OleDbConnection connect = new OleDbConnection();
        public StudentTutorPage()
        {
            InitializeComponent();
        }

        private void Homelabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeTutorPage HTP = new HomeTutorPage();
            HTP.ShowDialog();
        }

        private void ClassLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassTutorPage ctp = new ClassTutorPage();
            ctp.ShowDialog();
        }

        private void StudentLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTutorPage stp = new StudentTutorPage();
            stp.ShowDialog();
        }
        private void StudentTutorPage_Load(object sender, EventArgs e)
        {
            var course = new SQL()
            {
                Column_SELECT_1 = "CourseID",
                Table = "Course",
                Column_WHERE_1 = "LecturerID",
                String_Condition_1 = GlobalVar.UserID
            };
            course.Construct();
            course.FillComboBox(comboBox_CourseID);

            var Student = new SQL()
            {
                Column_SELECT_1 = "StudentID",
                Table = "Student",
            };
            Student.Construct();
            Student.FillComboBox(comboBox_StudentID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. When Searching up for a student, you will only see their Public Information. \n\n" +
                "2. To see more Information of the Student, please contact administration with their approval. \n\n" +
                "3. To use it, please write either the STUDENT_ID, The COURSE_ID (subject), or " +
                "The NAME of the student (either last or first names).");
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBox_StudentID.Text))
            {
                var show_table = new SQL()
                {
                    Column_SELECT_1 = "StudentID",
                    Column_SELECT_2 = "First_Name",
                    Column_SELECT_3 = "Last_Name",
                    Column_SELECT_4 = "Contact_Number",
                    Column_SELECT_5 = "Email",
                    Table = "Student",
                    Column_WHERE_1 = "StudentID",
                    String_Condition_1 = comboBox_StudentID.Text
                };
                show_table.Construct();
                if (show_table.Read() == false)
                    MessageBox.Show("Record Not Found.");
                show_table.DisplayGridTable(dataGridView_StudentInfo);
            }

            else if (!string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                var show_table = new SQL()
                {
                    Column_SELECT_1 = "StudentID",
                    Column_SELECT_2 = "First_Name",
                    Column_SELECT_3 = "Last_Name",
                    Column_SELECT_4 = "Contact_Number",
                    Column_SELECT_5 = "Email",
                    Table = "Student",
                    Column_WHERE_1 = "StudentID",
                    Column_WHERE_2 = "Last_Name",
                    String_Condition_1 = comboBox_StudentID.Text
                };
                show_table.Construct();
                if (show_table.Read() == false)
                    MessageBox.Show("Record Not Found.");
                show_table.DisplayGridTable(dataGridView_StudentInfo);
            }

            else if (!string.IsNullOrWhiteSpace(comboBox_CourseID.Text))
            {
                var course = new Course()
                {
                    CourseID = comboBox_CourseID.SelectedItem.ToString()
                };

                var show_table = new SQL()
                {
                    Column_SELECT_1 = "Student.StudentID",
                    Column_SELECT_2 = "Student.First_Name",
                    Column_SELECT_3 = "Student.Last_Name",
                    Column_SELECT_4 = "Student.Contact_Number",
                    Column_SELECT_5 = "Student.Email",
                    Table = "Student",
                    Table_Join_1 = "Enroll",
                    Column_Join_1a = "Enroll.StudentID",
                    Column_Join_1b = "Student.StudentID",
                    Column_WHERE_1 = "Enroll.CourseID",
                    String_Condition_1 = course.CourseID
                };
                show_table.Construct();
                if (show_table.Read() == false)
                    MessageBox.Show("Record Not Found.");
                show_table.DisplayGridTable(dataGridView_StudentInfo);
            }
            else
            {
                MessageBox.Show("Please fill in only ONE Criteria");
            }
        }

        private void comboBox_StudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_CourseID.Text = "";
            textBox_Name.Text = "";
        }

        private void comboBox_CourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_StudentID.Text = "";
            textBox_Name.Text = "";
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            comboBox_CourseID.Text = "";
            comboBox_StudentID.Text = "";
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }
    }
}
