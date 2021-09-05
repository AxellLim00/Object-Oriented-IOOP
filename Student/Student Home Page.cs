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
    public partial class HomeStudentPage : Form
    {
        public HomeStudentPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStudentPage UP = new UpdateStudentPage();
            UP.ShowDialog();
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

        private void HomeStudentPage_Load(object sender, EventArgs e)
        {
            var Student = new Student();
            textBox_StudentID.Text = Student.StudentID;
            textBox_firstname.Text = Student.FirstName;
            textBox_lastname.Text = Student.LastName;
            textBox_dob.Text = Student.DOB;
            textBox_contact.Text = Student.Contact;
            textBox_email.Text = Student.Email;
            textBox_address.Text = Student.Address;
            name2label.Text = Student.FirstName + " " + Student.LastName;
            textBox_dr.Text = Student.DR;
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
