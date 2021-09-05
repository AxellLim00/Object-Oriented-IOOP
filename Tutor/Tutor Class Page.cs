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
    public partial class ClassTutorPage : Form
    {
        public ClassTutorPage()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void Homelabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeTutorPage HTP = new HomeTutorPage();
            HTP.ShowDialog();
        }

        private void StudentLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTutorPage stp = new StudentTutorPage();
            stp.ShowDialog();
        }

        private void UpdateClassLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateClassPage ucp = new UpdateClassPage();
            ucp.ShowDialog();
        }

        private void CreateClassLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateClassPage ccp = new CreateClassPage();
            ccp.ShowDialog();
        }
        
        private void ClassTutorPage_Load(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click_1(object sender, EventArgs e)
        {
            string day = dateTimePicker.Value.DayOfWeek.ToString();
            var schedule = new SQL
            {
                Column_SELECT_1 = "CourseID",
                Column_SELECT_2 = "Course_Name",
                Column_SELECT_3 = "Location",
                Column_SELECT_4 = "Class_Start",
                Column_SELECT_5 = "Class_End",
                Table = "Course",
                Column_WHERE_1 = "Day_of_week",
                Column_WHERE_2 = "LecturerID",
                String_Condition_1 = day,
                String_Condition_2 = GlobalVar.UserID
            };
            schedule.Construct();
            schedule.DisplayGridTable(dataGridView_Schedule);
        }
    }
}
