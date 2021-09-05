using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_School_System
{
    class Lecturer : User
    {
        private string lecturerID;
        private string fullName;
        private string email;
        private string contactNumber;
        private SQL lecturer_info;

        public Lecturer()
        {
            lecturer_info.Column_SELECT_1 = "LecturerID";
            lecturer_info.Column_SELECT_2 = "First_Name";
            lecturer_info.Column_SELECT_3 = "Last_Name";
            lecturer_info.Column_SELECT_4 = "Email";
            lecturer_info.Column_SELECT_5 = "Contact_Number";
            lecturer_info.Table = "Lecturer";
            lecturer_info.Column_WHERE_1 = "LecturerID";
            lecturer_info.String_Condition_1 = GlobalVar.UserID;
            
            lecturer_info.Construct();

            lecturer_info.GetData(5);
            lecturerID = lecturer_info.ResultGetData[0].ToString();
            fullName = lecturer_info.ResultGetData[1].ToString() + " " + lecturer_info.ResultGetData[2].ToString();
            email = lecturer_info.ResultGetData[3].ToString();
            contactNumber = lecturer_info.ResultGetData[4].ToString();

        }
        public string LecturerID
        {
            get
            {
                return lecturerID;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
        }
        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
        }

    } 

}
