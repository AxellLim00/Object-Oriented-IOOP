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
    public partial class TableStudentPage : Form
    {
        public TableStudentPage()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void TableStudentPage_Load(object sender, EventArgs e)
        {

            string date = System.DateTime.Today.ToString("dddd,MM/dd/yyyy");
            labelnowtime.Text = date;
            labelnowhour.Text = DateTime.Now.ToString("hh:mm:ss tt"); //https://stackoverflow.com/questions/4380639/how-to-display-the-current-time-and-date-in-c-sharp

            var display_tt = new SQL()
            {
                Column_SELECT_1 = "Course.[CourseID]",
                Column_SELECT_2 = "Course.[Day_of_week]",
                Column_SELECT_3 = "Course.[Course_Name]",
                Column_SELECT_4 = "Course.[Location]",
                Column_SELECT_5 = "Course.[Class_Start]",
                Column_SELECT_6 = "Course.[Class_End]",
                Column_SELECT_7 = "Lecturer.[First_Name] as Lecturer_Name",
                Table = "Course",
                Column_Join_1a = "Course.[LecturerID]",
                Column_Join_1b = "Lecturer.[LecturerID]",
                Table_Join_1 = "Lecturer",
                Table_Join_2 = "Enroll",
                Column_Join_2a = "Enroll.[CourseID]",
                Column_Join_2b = "Course.[CourseID]",
                Column_WHERE_1 = "Enroll.[StudentID]",
                String_Condition_1 = GlobalVar.UserID
            };
            display_tt.Construct();
            display_tt.DisplayGridTable(dataGridView_schedule);
        }
    }
}
