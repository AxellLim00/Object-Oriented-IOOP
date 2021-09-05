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
    public partial class HomeTutorPage : Form
    {
        public HomeTutorPage()
        {
            InitializeComponent();
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
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

        private void HomeTutorPage_Load(object sender, EventArgs e)
        {
            var lecture = new Lecturer();
            textBox_ID.Text = lecture.LecturerID;
            textBox_FirstName.Text = lecture.FullName;
            textBox_Email.Text = lecture.Email;
            textBox_Contact.Text = lecture.ContactNumber;

        }
    }
}
