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
    public partial class UpdateClassPage : Form
    {
        string currentLocation = "";
        string currentDay = "";
        double TimeStart1;
        double TimeEnd1;
        double TimeStart2;
        double TimeEnd2;

        OleDbConnection connect = new OleDbConnection();
        bool flag1 = false;
        public UpdateClassPage()
        {
            InitializeComponent();
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

        private void CreateClassLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateClassPage ccp = new CreateClassPage();
            ccp.ShowDialog();
        }

        private void Homelabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeTutorPage HTP = new HomeTutorPage();
            HTP.ShowDialog();
        }

        private void UpdateClassPage_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = University System Database.accdb";
            connect.Open();

            var FillCombobox = new SQL()
            {
                Column_SELECT_1 = "Distinct(CourseID)",
                Table = "Course",
                Column_WHERE_1 = "LecturerID",
                String_Condition_1 = GlobalVar.UserID
            };
            FillCombobox.Construct();
            FillCombobox.FillComboBox(comboBox_CourseID);
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            var FillCombobox = new SQL()
            {
                Column_SELECT_1 = "*",
                Table = "Course",
                Column_WHERE_1 = "CourseID",
                String_Condition_1 = comboBox_CourseID.Text
            };
            FillCombobox.Construct();
            FillCombobox.DisplayGridTable(dataGridView_DisplayTable);
        }

        private void button_DisplayAll_Click(object sender, EventArgs e)
        {
            var FillCombobox = new SQL()
            {
                Column_SELECT_1 = "CourseID",
                Column_SELECT_2 = "Course_Name",
                Column_SELECT_3 = "Location",
                Column_SELECT_4 = "Class_Start",
                Column_SELECT_5 = "Class_End",
                Column_SELECT_6 = "Day_of_Week",
                Table = "Course",
            };
            FillCombobox.Construct();
            FillCombobox.DisplayGridTable(dataGridView_DisplayTable);
        }

        private void radioButton_CourseName_CheckedChanged(object sender, EventArgs e)
        {
            label_NewName.Visible = true;
            textBox_NewInfo.Visible = true;
            label_NewLocation.Visible = false;
            comboBox_Location.Visible = false;
            label_NewStart.Visible = false;
            comboBox_ClassStart.Visible = false;
            label_NewEnd.Visible = false;
            comboBox_ClassEnd.Visible = false;
        }

        private void radioButton_Location_CheckedChanged(object sender, EventArgs e)
        {
            label_NewName.Visible = false;
            textBox_NewInfo.Visible = false;
            label_NewLocation.Visible = true;
            comboBox_Location.Visible = true;
            label_NewStart.Visible = false;
            comboBox_ClassStart.Visible = false;
            label_NewEnd.Visible = false;
            comboBox_ClassEnd.Visible = false;
        }

        private void radioButton_ClassTime_CheckedChanged(object sender, EventArgs e)
        {
            label_NewName.Visible = false;
            textBox_NewInfo.Visible = false;
            label_NewLocation.Visible = false;
            comboBox_Location.Visible = false;
            label_NewStart.Visible = true;
            comboBox_ClassStart.Visible = true;
            label_NewEnd.Visible = true;
            comboBox_ClassEnd.Visible = true;
        }

        private void comboBox_ClassStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            double starthour1;
            double startminute1;

            starthour1 = double.Parse(comboBox_ClassStart.Text.Remove(2));
            startminute1 = double.Parse(comboBox_ClassStart.Text.Remove(0, 3)) * 0.01;
            TimeStart1 = starthour1 + startminute1;
        }

        private void comboBox_ClassEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            double endhour1;
            double endminute1;

            endhour1 = double.Parse(comboBox_ClassEnd.Text.Remove(2));
            endminute1 = double.Parse(comboBox_ClassEnd.Text.Remove(0, 3)) * 0.01;
            TimeEnd1 = endhour1 + endminute1;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var updatedata = new SQL();
            flag1 = false;
            string column;
            string change;
            string set = "";
            if (radioButton_CourseName.Checked)
            {
                column = "Course_Name";
                change = textBox_NewInfo.Text;
                set = column + " = '" + change + "'";
            }
            else if (radioButton_Location.Checked)
            {
                column = "Location";
                change = comboBox_Location.Text;
                set = column + " = '" + change + "'";

                OleDbCommand time = new OleDbCommand
                {
                    CommandText = "Select Class_Start, Class_End  From Course Where CourseID = '" + comboBox_CourseID.Text + "'",
                    Connection = connect
                };
                OleDbDataReader timereader = time.ExecuteReader();
                if (timereader.Read() == true)
                {
                    string startTime = timereader[0].ToString();
                    string EndTime = timereader[1].ToString();
                    double starthour1;
                    double startminute1;
                    double endhour1;
                    double endminute1;

                    endhour1 = double.Parse(EndTime.Remove(2));
                    endminute1 = double.Parse(EndTime.Remove(0, 3)) * 0.01;
                    TimeEnd1 = endhour1 + endminute1;

                    starthour1 = double.Parse(startTime.Remove(2));
                    startminute1 = double.Parse(startTime.Remove(0, 3)) * 0.01;
                    TimeStart1 = starthour1 + startminute1;
                    //MessageBox.Show("Input: Start = " + TimeStart1 + "||End = " + TimeEnd1); //(for checking purposes)
                }

                OleDbCommand check = new OleDbCommand
                {
                    CommandText = "Select Class_Start, Class_End, Day_of_week  From Course Where Location = '" + change + "'",
                    Connection = connect
                };

                OleDbDataReader results = check.ExecuteReader();

                while (results.Read())
                {
                    MessageBox.Show("Input: Start = " + TimeStart1 + "||End = " + TimeEnd1 + "\n look data: Start = " + TimeStart2 + "|| End = " + TimeEnd2);
                    string start = results[0].ToString();
                    string end = results[1].ToString();
                    string day = results[2].ToString();
                    if (!(start == "0"))
                    {
                        MessageBox.Show("Input: Start = " + TimeStart1 + "||End = " + TimeEnd1 + "\n look data: Start = " + TimeStart2 + "|| End = " + TimeEnd2);
                        if (day == currentDay)
                        {
                            double starthour2;
                            double startminute2;
                            double endhour2;
                            double endminute2;

                            starthour2 = double.Parse(start.Remove(2));
                            startminute2 = double.Parse(start.Remove(0, 3)) * 0.01;
                            TimeStart2 = starthour2 + startminute2;

                            endhour2 = double.Parse(end.Remove(2));
                            endminute2 = double.Parse(end.Remove(0, 3)) * 0.01;
                            TimeEnd2 = endhour2 + endminute2;

                            MessageBox.Show("Input: Start = " + TimeStart1 + "||End = " + TimeEnd1 + "\n look data: Start = " + TimeStart2 + "|| End = " + TimeEnd2); //To check the Time Condition 

                            if ((TimeStart1 >= TimeStart2 && TimeEnd1 <= TimeEnd2) || (TimeStart1 <= TimeStart2 && TimeEnd1 >= TimeEnd2)
                            || (TimeEnd1 < TimeEnd2 && TimeEnd1 >= TimeStart2) || (TimeStart1 > TimeStart2 && TimeStart1 <= TimeEnd2)
                            || TimeStart1 == 0 || TimeEnd1 == 0)
                            {
                                flag1 = true;
                                break;
                            }
                        }
                    }
                }

            }
            else if (radioButton_ClassTime.Checked)
            {
                set = "Class_Start = '" + comboBox_ClassStart.Text + "', Class_End = '" + comboBox_ClassEnd.Text + "'";

                OleDbCommand check = new OleDbCommand
                {
                    CommandText = "Select Class_Start, Class_End, Day_of_week  From Course Where Location = '" + currentLocation + "'",
                    Connection = connect
                };

                OleDbDataReader results = check.ExecuteReader();
                while (results.Read())
                {
                    string start = results[0].ToString();
                    string end = results[1].ToString();
                    string day = results[2].ToString();
                    if (!(start == "0"))
                    {
                        if (day == currentDay)
                        {
                            double starthour2;
                            double startminute2;
                            double endhour2;
                            double endminute2;


                            starthour2 = double.Parse(start.Remove(2));
                            startminute2 = double.Parse(start.Remove(0, 3)) * 0.01;
                            TimeStart2 = starthour2 + startminute2;

                            endhour2 = double.Parse(end.Remove(2));
                            endminute2 = double.Parse(end.Remove(0, 3)) * 0.01;
                            TimeEnd2 = endhour2 + endminute2;

                            //MessageBox.Show("Input: Start = " + TimeStart1 + "||End = " + TimeEnd1 + "\n look data: Start = " + TimeStart2 + "|| End = " + TimeEnd2); //To check the Time Condition 

                            if ((TimeStart1 >= TimeStart2 && TimeEnd1 <= TimeEnd2) || (TimeStart1 <= TimeStart2 && TimeEnd1 >= TimeEnd2)
                            || (TimeEnd1 <= TimeEnd2 && TimeEnd1 > TimeStart2) || (TimeStart1 > TimeStart2 && TimeStart1 <= TimeEnd2)
                            || TimeStart1 == 0 || TimeEnd1 == 0)
                            {
                                flag1 = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (flag1 == false)
            {
                OleDbCommand display = new OleDbCommand
                {
                    CommandText = "Update Course Set " + set + " Where CourseID = '" + comboBox_CourseID.Text + "';",
                    Connection = connect
                };
                if (display.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Update Failed, Data Invalid");
                }
            }
            else if (flag1 == true)
            {
                MessageBox.Show("Update Failed, Time Conflict with other Class");
            }
        }

        private void comboBox_CourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var display = new SQL()
            {
                Column_SELECT_1 = "*",
                Table = "Course",
                Column_WHERE_1 = "CourseID",
                String_Condition_1 = comboBox_CourseID.Text
            };
            display.Construct();
            display.DisplayGridTable(dataGridView_DisplayTable);
            display.GetData(9);

            currentLocation = display.ResultGetData[2].ToString();
            currentDay = display.ResultGetData[8].ToString();
        }

        private void label_NewName_Click(object sender, EventArgs e)
        {

        }

        private void label_NewLocation_Click(object sender, EventArgs e)
        {

        }

        private void label_NewStart_Click(object sender, EventArgs e)
        {

        }

        private void label_CourseName_Click(object sender, EventArgs e)
        {

        }
    }
}
