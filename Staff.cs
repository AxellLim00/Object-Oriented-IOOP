using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_School_System
{
    class Staff :  User
    {
        private string staffID;
        private string name;
        private string staffKey;
        private SQL staff_info;
        public string StaffID
        {
            get
            {
                return staffID;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string StaffKey
        {
            get
            {
                return staffKey;
            }
        }

        public Staff()
        {
            staff_info.Column_SELECT_1 = "StaffID";
            staff_info.Column_SELECT_2 = "Full_Name";
            staff_info.Column_SELECT_3 = "Staff_Key";
            staff_info.Table = "Staff";
            staff_info.Column_WHERE_1 = "StaffID";
            staff_info.String_Condition_1 = GlobalVar.UserID;

            staff_info.Construct();

            staff_info.GetData(3);
            staffID = staff_info.ResultGetData[0].ToString();
            name = staff_info.ResultGetData[1].ToString();
            staffKey = staff_info.ResultGetData[2].ToString();
            
        }
    }
}
