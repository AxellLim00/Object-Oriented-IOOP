using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_School_System
{
    public class User
    {
        private string username;
        private string password;
        private string type;
        private bool flag;
        private SQL Login;
        private SQL get_type;


        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
        

        public bool login()
        {
            Login.Column_SELECT_1 = "User_Type";
            Login.Table = "Login";
            Login.Column_WHERE_1 = "Username";
            Login.Column_WHERE_2 = "Password";
            Login.String_Condition_1 = username;
            Login.String_Condition_2 = password;
            Login.Construct();
            flag = Login.Read();

            return flag;
        }

        public void getType()
        {
            get_type.Column_SELECT_1 = "User_Type";
            get_type.Table = "Login";
            get_type.Column_WHERE_1 = "Username";
            get_type.Column_WHERE_2 = "Password";
            get_type.String_Condition_1 = username;
            get_type.String_Condition_2 = password;

            get_type.Construct();
            get_type.GetData(1);
            type = get_type.ResultGetData[0];
        }

    }

    
}
