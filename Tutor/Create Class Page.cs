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
    public partial class CreateClassPage : Form
    {
        OleDbConnection connect = new OleDbConnection();
        public CreateClassPage()
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

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
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

        private void CreateClassPage_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = University System Database.accdb";
            connect.Open();

            var FillCombobox = new SQL()
            {
                Column_SELECT_1 = "Distinct(Day_of_week)",
                Table = "Course",
            };
            FillCombobox.Construct();
            FillCombobox.FillComboBox(comboBox_Day);

            var display_table = new SQL()
            {
                Column_SELECT_1 = "CourseID",
                Column_SELECT_2 = "Course_Name",
                Column_SELECT_3 = "Location",
                Column_SELECT_4 = "Class_Start",
                Column_SELECT_5 = "Class_End",
                Column_SELECT_6 = "Day_of_week",
                Table = "Course",
            };
            display_table.Construct();
            display_table.DisplayGridTable(dataGridView_ClassInfo);
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            var display_table = new SQL()
            {
                Column_SELECT_1 = "CourseID",
                Column_SELECT_2 = "Course_Name",
                Column_SELECT_3 = "Location",
                Column_SELECT_4 = "Class_Start",
                Column_SELECT_5 = "Class_End",
                Column_SELECT_6 = "Day_of_week",
                Table = "Course",
            };
            display_table.Construct();
            display_table.DisplayGridTable(dataGridView_ClassInfo);
        }

        private void buttonCreateClass_Click(object sender, EventArgs e)
        {
            bool flag1 = false;
            if (!string.IsNullOrWhiteSpace(textBox_CourseID.Text) && !string.IsNullOrWhiteSpace(textBox_Course_Name.Text)
                && !string.IsNullOrWhiteSpace(comboBox_Location.Text) && !string.IsNullOrWhiteSpace(comboBox_Location.Text) &&
                !string.IsNullOrWhiteSpace(comboBox_ClassEnd.Text) && !string.IsNullOrWhiteSpace(textBox_fee.Text) &&
                !string.IsNullOrWhiteSpace(comboBox_Day.Text))
            {
                try
                {
                    int.Parse(textBox_fee.Text);
                }
                catch
                {
                    MessageBox.Show("Insert Tuition Fee in Digit");
                    flag1 = true;
                }


                OleDbCommand checkID = new OleDbCommand
                {
                    CommandText = "Select CourseID  From Course",
                    Connection = connect
                };
                OleDbDataReader result = checkID.ExecuteReader();
                while (result.Read())
                {
                    string courseid = result[0].ToString();
                    if (textBox_CourseID.Text == courseid)
                    {
                        flag1 = true;
                        break;
                    }
                }
                result.Close();

                OleDbCommand check = new OleDbCommand
                {
                    CommandText = "Select Class_Start, Class_End, Day_of_week  From Course Where Location = '" + comboBox_Location.Text + "'",
                    Connection = connect
                };

                OleDbDataReader results = check.ExecuteReader();
                while (results.Read())
                {
                    string start = results[0].ToString();
                    string end = results[1].ToString();
                    string day = results[2].ToString();

                    if (day == comboBox_Day.Text)
                    {
                        double starthour1;
                        double startminute1;
                        double endhour1;
                        double endminute1;
                        double TimeStart1;
                        double TimeEnd1;

                        starthour1 = double.Parse(comboBox_ClassStart.Text.Remove(2));
                        startminute1 = double.Parse(comboBox_ClassStart.Text.Remove(0, 3)) * 0.01;
                        TimeStart1 = starthour1 + startminute1;

                        endhour1 = double.Parse(comboBox_ClassEnd.Text.Remove(2));
                        endminute1 = double.Parse(comboBox_ClassEnd.Text.Remove(0, 3)) * 0.01;
                        TimeEnd1 = endhour1 + endminute1;

                        double starthour2;
                        double startminute2;
                        double endhour2;
                        double endminute2;
                        double TimeStart2;
                        double TimeEnd2;

                        starthour2 = double.Parse(start.Remove(2));
                        startminute2 = double.Parse(start.Remove(0, 3)) * 0.01;
                        TimeStart2 = starthour2 + startminute2;

                        endhour2 = double.Parse(end.Remove(2));
                        endminute2 = double.Parse(end.Remove(0, 3)) * 0.01;
                        TimeEnd2 = endhour2 + endminute2;

                        MessageBox.Show("Input: Start = " + TimeStart1 + "||End = " + TimeEnd1 + "\n look data: Start = " + TimeStart2 + "|| End = " + TimeEnd2); //To check the Time Condition 

                        if ((TimeStart1 >= TimeStart2 && TimeEnd1 <= TimeEnd2) || (TimeStart1 < TimeStart2 && TimeEnd1 > TimeEnd2)
                        || (TimeEnd1 < TimeEnd2 && TimeEnd1 > TimeStart2) || (TimeStart1 > TimeStart2 && TimeStart1 < TimeEnd2))
                        {
                            flag1 = true;
                            break;
                        }
                    }
                }
                results.Close();


                if (flag1 == false)
                {
                    string userid = GlobalVar.UserID;
                    OleDbCommand class_creation = new OleDbCommand
                    {
                        CommandText = "Insert Into Course(CourseID, Course_Name, Location, Class_Start, Class_End, Fee, LecturerID, Duration, Day_of_week)" +
                        " Values('" + textBox_CourseID.Text + "', '" + textBox_Course_Name.Text + "', '" + comboBox_Location.Text + "', '" + comboBox_ClassStart.Text + "', '"
                        + comboBox_ClassEnd.Text + "', " + textBox_fee.Text + ", '" + userid + "', '6 Months', '" + comboBox_Day.Text + "');",
                        Connection = connect
                    };
                    if (class_creation.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Class Creation Successful");
                    }
                    else
                    {
                        MessageBox.Show("Creation Failed, Check your info");
                    }
                }
                else
                {
                    MessageBox.Show("Creation Failed, Check your info");

                }
            }
            else
            {
                MessageBox.Show("Creation Failed, Check your info");
            }
        }
    }
}
