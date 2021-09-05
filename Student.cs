using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_School_System
{
    class Student : User
    {
        private string studentID;
        private string firstName;
        private string lastName;
        private string dOB;
        private string contact;
        private string email;
        private string address;
        private string dR;
        private SQL student_info;
        public Student()
        {
            student_info.Column_SELECT_1 = "StudentID";
            student_info.Column_SELECT_2 = "First_Name";
            student_info.Column_SELECT_3 = "Last_Name";
            student_info.Column_SELECT_4 = "Date_of_Birth";
            student_info.Column_SELECT_5 = "Contact_Number";
            student_info.Column_SELECT_6 = "Email";
            student_info.Column_SELECT_7 = "Address";
            student_info.Column_SELECT_8 = "Date_Registered";
            student_info.Table = "Student";
            student_info.Column_WHERE_1 = "StudentID";
            student_info.String_Condition_1 = GlobalVar.UserID;

            student_info.Construct();

            student_info.GetData(9);
            studentID = student_info.ResultGetData[0].ToString();
            firstName = student_info.ResultGetData[1].ToString();
            lastName = student_info.ResultGetData[2].ToString();
            dOB = student_info.ResultGetData[3].ToString();
            contact = student_info.ResultGetData[4].ToString();
            email = student_info.ResultGetData[5].ToString();
            address = student_info.ResultGetData[6].ToString();
            dR = student_info.ResultGetData[7].ToString();
        }


        public string StudentID
        {
            get
            {
                return studentID;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public string DOB
        {
            get
            {
                return dOB;
            }
        }
        public string Contact
        {
            get
            {
                return contact;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }

        public string DR
        {
            get
            {
                return dR;
            }
        }
    }
}
