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
    public partial class HomeStaffPage : Form
    {
        public HomeStaffPage()
        {
            InitializeComponent();
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

        private void RegisterStudentLabel_Click(object sender, EventArgs e)
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

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CourseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseStaffPage csp = new CourseStaffPage();
            csp.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_staffid.ReadOnly = true ;
        }

        private void HomeStaffPage_Load(object sender, EventArgs e)
        {
            var Admin = new Staff();
            textBox_staffid.Text = Admin.StaffID;
            textBox_name.Text = Admin.Name;
            textBox_key.Text = Admin.StaffKey;
            name2label.Text = Admin.Name;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            textBox_name.ReadOnly = true;
        }

        private void textBox_key_TextChanged(object sender, EventArgs e)
        {
            textBox_key.ReadOnly = true;
        }
    }
}
