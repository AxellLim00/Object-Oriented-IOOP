using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace IOOP_School_System
{
    class SQL
    {
        OleDbConnection connect = new OleDbConnection();
        private string table;

        private string string_Condition_1;
        private string string_Condition_2;

        private string string_insert_1;
        private string string_insert_2;
        private string string_insert_3;
        private string string_insert_4;
        private string string_insert_5;
        private string string_insert_6;
        private string string_insert_7;
        private string string_insert_8;
        private string string_insert_9;
        private string number_insert_1;

        private string string_update_1;
        private string string_update_2;

        private string column_SELECT_1;
        private string column_SELECT_2;
        private string column_SELECT_3;
        private string column_SELECT_4;
        private string column_SELECT_5;
        private string column_SELECT_6;
        private string column_SELECT_7;
        private string column_SELECT_8;
        private string column_SELECT_9;

        private string column_WHERE_1;
        private string column_WHERE_2;

        private string column_INSERT_1;
        private string column_INSERT_2;
        private string column_INSERT_3;
        private string column_INSERT_4;
        private string column_INSERT_5;
        private string column_INSERT_6;
        private string column_INSERT_7;
        private string column_INSERT_8;
        private string column_INSERT_9;
        private string column_number_INSERT_1;


        private string table_Join_1;
        private string table_Join_2;
        private string column_Join_1a;
        private string column_Join_1b;
        private string column_Join_2a;
        private string column_Join_2b;

        private string column_UPDATE_1;
        private string column_UPDATE_2;

        private string SELECT;
        private string FROM;
        private string JOIN;
        private string WHERE;
        private string INSERT;
        private string VALUES;
        private string UPDATE;
        private string SET;
        private int size;
        public string[] ResultGetData;
        private bool flagBool = false;


        //Don't forget the ';' on every query end.
        public SQL()
        {
            connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = University System Database.accdb";
            connect.Open();
        }

        public string Table { get => table; set => table = value; }
        public string String_Condition_1 { get => string_Condition_1; set => string_Condition_1 = value; }
        public string String_Condition_2 { get => string_Condition_2; set => string_Condition_2 = value; }
        public string String_insert_1 { get => string_insert_1; set => string_insert_1 = value; }
        public string String_insert_2 { get => string_insert_2; set => string_insert_2 = value; }
        public string String_insert_3 { get => string_insert_3; set => string_insert_3 = value; }
        public string String_insert_4 { get => string_insert_4; set => string_insert_4 = value; }
        public string String_insert_5 { get => string_insert_5; set => string_insert_5 = value; }
        public string String_insert_6 { get => string_insert_6; set => string_insert_6 = value; }
        public string String_insert_7 { get => string_insert_7; set => string_insert_7 = value; }
        public string String_insert_8 { get => string_insert_8; set => string_insert_8 = value; }
        public string String_insert_9 { get => string_insert_9; set => string_insert_9 = value; }
        public string Number_insert_1 { get => number_insert_1; set => number_insert_1 = value; }
        public string String_update_1 { get => string_update_1; set => string_update_1 = value; }
        public string String_update_2 { get => string_update_2; set => string_update_2 = value; }
        public string Column_SELECT_1 { get => column_SELECT_1; set => column_SELECT_1 = value; }
        public string Column_SELECT_2 { get => column_SELECT_2; set => column_SELECT_2 = value; }
        public string Column_SELECT_3 { get => column_SELECT_3; set => column_SELECT_3 = value; }
        public string Column_SELECT_4 { get => column_SELECT_4; set => column_SELECT_4 = value; }
        public string Column_SELECT_5 { get => column_SELECT_5; set => column_SELECT_5 = value; }
        public string Column_SELECT_6 { get => column_SELECT_6; set => column_SELECT_6 = value; }
        public string Column_SELECT_7 { get => column_SELECT_7; set => column_SELECT_7 = value; }
        public string Column_SELECT_8 { get => column_SELECT_8; set => column_SELECT_8 = value; }
        public string Column_SELECT_9 { get => column_SELECT_9; set => column_SELECT_9 = value; }
        public string Column_WHERE_1 { get => column_WHERE_1; set => column_WHERE_1 = value; }
        public string Column_WHERE_2 { get => column_WHERE_2; set => column_WHERE_2 = value; }
        public string Column_INSERT_1 { get => column_INSERT_1; set => column_INSERT_1 = value; }
        public string Column_INSERT_2 { get => column_INSERT_2; set => column_INSERT_2 = value; }
        public string Column_INSERT_3 { get => column_INSERT_3; set => column_INSERT_3 = value; }
        public string Column_INSERT_4 { get => column_INSERT_4; set => column_INSERT_4 = value; }
        public string Column_INSERT_5 { get => column_INSERT_5; set => column_INSERT_5 = value; }
        public string Column_INSERT_6 { get => column_INSERT_6; set => column_INSERT_6 = value; }
        public string Column_INSERT_7 { get => column_INSERT_7; set => column_INSERT_7 = value; }
        public string Column_INSERT_8 { get => column_INSERT_8; set => column_INSERT_8 = value; }
        public string Column_INSERT_9 { get => column_INSERT_9; set => column_INSERT_9 = value; }
        public string Column_number_INSERT_1 { get => column_number_INSERT_1; set => column_number_INSERT_1 = value; }
        public string Table_Join_1 { get => table_Join_1; set => table_Join_1 = value; }
        public string Table_Join_2 { get => table_Join_2; set => table_Join_2 = value; }
        public string Column_Join_1a { get => column_Join_1a; set => column_Join_1a = value; }
        public string Column_Join_1b { get => column_Join_1b; set => column_Join_1b = value; }
        public string Column_Join_2a { get => column_Join_2a; set => column_Join_2a = value; }
        public string Column_Join_2b { get => column_Join_2b; set => column_Join_2b = value; }
        public string Column_UPDATE_1 { get => column_UPDATE_1; set => column_UPDATE_1 = value; }
        public string Column_UPDATE_2 { get => column_UPDATE_2; set => column_UPDATE_2 = value; }
       

        public void Construct()
        {
            SELECT = "SELECT " + Column_SELECT_1;
            if (!(string.IsNullOrEmpty(Column_SELECT_2)))
            {
                SELECT = SELECT + ", " + Column_SELECT_2;
                if (!(string.IsNullOrEmpty(Column_SELECT_3)))
                {
                    SELECT = SELECT + ", " + Column_SELECT_3;
                    if (!(string.IsNullOrEmpty(Column_SELECT_4)))
                    {
                        SELECT = SELECT + ", " + Column_SELECT_4;
                        if (!(string.IsNullOrEmpty(Column_SELECT_5)))
                        {
                            SELECT = SELECT + ", " + Column_SELECT_5;
                            if (!(string.IsNullOrEmpty(Column_SELECT_6)))
                            {
                                SELECT = SELECT + ", " + Column_SELECT_6;
                                if (!(string.IsNullOrEmpty(Column_SELECT_7)))
                                {
                                    SELECT = SELECT + ", " + Column_SELECT_7;
                                    if (!(string.IsNullOrEmpty(Column_SELECT_8)))
                                    {
                                        SELECT = SELECT + ", " + Column_SELECT_8;
                                        if (!(string.IsNullOrEmpty(Column_SELECT_9)))
                                        {
                                            SELECT = SELECT + ", " + Column_SELECT_9;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            if (!(string.IsNullOrEmpty(Table_Join_1)))
            {
                JOIN = " INNER JOIN " + Table_Join_1 + " ON " + Column_Join_1a + " = " + Column_Join_1b + ")" ;
                if (!(string.IsNullOrEmpty(Table_Join_2)))
                {
                    JOIN = JOIN + " INNER JOIN " + Table_Join_2 + " ON " + Column_Join_2a + " = " + Column_Join_2b + ")";
                }
            }
            else
            {
                JOIN = "";
            }

            if (string.IsNullOrEmpty(Table_Join_1))
            {
                FROM = " FROM " + Table;
            }
            else
            {
                if (string.IsNullOrEmpty(Table_Join_2))
                {
                    FROM = " FROM (" + Table;
                }
                else
                {
                    FROM = " FROM ((" + Table;
                }

            }

            if (!(string.IsNullOrEmpty(Column_WHERE_1)))
            {
                WHERE = " WHERE " + Column_WHERE_1 + " = '" + String_Condition_1 + "'";
                if (!(string.IsNullOrEmpty(Column_WHERE_2)))
                {
                    WHERE = WHERE + " AND " + Column_WHERE_2 + " = '" + String_Condition_2 + "'";
                }
                else
                {
                    if (!(string.IsNullOrEmpty(String_Condition_2)))
                    {
                        WHERE = WHERE + " OR " + Column_WHERE_1 + " = '" + String_Condition_2 + "'";
                    }
                }

            }

            if (!(string.IsNullOrEmpty(String_insert_1)))
            {
                if (!(string.IsNullOrEmpty(Column_INSERT_1)))
                {
                    INSERT = "INSERT INTO " + Table + "(" + Column_INSERT_1;
                    if (!(string.IsNullOrEmpty(Column_INSERT_2)))
                    {
                        INSERT = INSERT + ", " + Column_INSERT_2;
                        if (!(string.IsNullOrEmpty(Column_INSERT_3)))
                        {
                            INSERT = INSERT + ", " + Column_INSERT_3;
                            if (!(string.IsNullOrEmpty(Column_INSERT_4)))
                            {
                                INSERT = INSERT + ", " + Column_INSERT_4;
                                if (!(string.IsNullOrEmpty(Column_INSERT_5)))
                                {
                                    INSERT = INSERT + ", " + Column_INSERT_5;
                                    if (!(string.IsNullOrEmpty(Column_INSERT_6)))
                                    {
                                        INSERT = INSERT + ", " + Column_INSERT_6;
                                        if (!(string.IsNullOrEmpty(Column_INSERT_7)))
                                        {
                                            INSERT = INSERT + ", " + Column_INSERT_7;
                                            if (!(string.IsNullOrEmpty(Column_INSERT_8)))
                                            {
                                                INSERT = INSERT + ", " + Column_INSERT_8;
                                                if (!(string.IsNullOrEmpty(Column_INSERT_9)))
                                                {
                                                    INSERT = INSERT + ", " + Column_INSERT_9;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!(string.IsNullOrEmpty(Column_number_INSERT_1)))
                    {
                        INSERT = INSERT + ", " + Column_number_INSERT_1;
                    }
                    INSERT = INSERT + ")";
                }
                else
                {
                    INSERT = "INSERT INTO " + Table;
                }

                VALUES = " VALUES ('" + String_insert_1 + "'";
                if (!(string.IsNullOrEmpty(String_insert_2)))
                {
                    VALUES = VALUES + ", '" + String_insert_2 + "'";
                    if (!(string.IsNullOrEmpty(String_insert_3)))
                    {
                        VALUES = VALUES + ", '" + String_insert_3 + "'";
                        if (!(string.IsNullOrEmpty(String_insert_4)))
                        {
                            VALUES = VALUES + ", '" + String_insert_4 + "'";
                            if (!(string.IsNullOrEmpty(String_insert_5)))
                            {
                                VALUES = VALUES + ", '" + String_insert_5 + "'";
                                if (!(string.IsNullOrEmpty(String_insert_6)))
                                {
                                    VALUES = VALUES + ", '" + String_insert_6 + "'";
                                    if (!(string.IsNullOrEmpty(String_insert_7)))
                                    {
                                        VALUES = VALUES + ", '" + String_insert_7 + "'";
                                        if (!(string.IsNullOrEmpty(String_insert_8)))
                                        {
                                            VALUES = VALUES + ", '" + String_insert_8 + "'";
                                            if (!(string.IsNullOrEmpty(String_insert_9)))
                                            {
                                                VALUES = VALUES + ", '" + String_insert_9 + "'";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (!(string.IsNullOrEmpty(Number_insert_1)))
                {
                    VALUES = VALUES + ", " + Number_insert_1;

                }
                VALUES = VALUES + ")";
            }

            if (!(string.IsNullOrEmpty(Column_UPDATE_1)))
            {
                UPDATE = "UPDATE " + Table;
                SET = " SET " + Column_UPDATE_1 + " = '" + String_update_1 + "'";
                if (!(string.IsNullOrEmpty(String_update_2)))
                {
                    SET = SET+ ", " + Column_UPDATE_2 + " = '" + String_update_2 + "'";
                }
            }
        }

        public bool Update()
        {
            OleDbCommand update = new OleDbCommand
            {
                CommandText = UPDATE + SET + WHERE + ";",
                Connection = connect,
                CommandType = CommandType.Text
            };

            if (update.ExecuteNonQuery() == 1)
            {
                flagBool = true;//success
            }
            else
            {
                flagBool = false;//fail
            }
            return flagBool;
        }

        public bool Insert()
        {
            OleDbCommand insert = new OleDbCommand
            {
                CommandText = INSERT + VALUES + ";",
                Connection = connect,
                CommandType = CommandType.Text
            };

            if (insert.ExecuteNonQuery() == 1)
            {
                flagBool = true;//success
            }
            else
            {
                flagBool = false;//fail
            }
            return flagBool;
        }

        public bool Check(string @Text_To_Be_Checked)
        {
            OleDbCommand check = new OleDbCommand
            {
                CommandText = SELECT + FROM + JOIN + WHERE + ";",
                Connection = connect,
                CommandType = CommandType.Text
            };
            OleDbDataReader result = check.ExecuteReader();
            while (result.Read())
            {
                string info = result[0].ToString();
                if (@Text_To_Be_Checked == info)
                {
                    flagBool = true;//found
                    break;
                }
                else
                {
                    flagBool = false;
                }
            }
            return flagBool;
        }

        public bool Read()
        {
            OleDbCommand FindItem = new OleDbCommand
            {
                CommandText = SELECT + FROM + JOIN + WHERE + ";",
                Connection = connect,
                CommandType = CommandType.Text
            };
            OleDbDataReader check = FindItem.ExecuteReader();
            if (check.Read() == true)
            {
                flagBool = true;
            }
            else
            {
                flagBool = false;
            }
            return flagBool;
        }

        public void DisplayGridTable(System.Windows.Forms.DataGridView @Grid_Table_to_View)
        {
            var display_table = new OleDbCommand()
            {
                Connection = connect,
                CommandText = SELECT + FROM + JOIN + WHERE + ";", //JOIN ands SET are Optional
                CommandType = CommandType.Text
            };

            OleDbDataAdapter DataDisplay = new OleDbDataAdapter(display_table);
            DataTable table = new DataTable();
            DataDisplay.Fill(table);
            @Grid_Table_to_View.DataSource = table;
        }

        public void FillComboBox(System.Windows.Forms.ComboBox @Combo_Box_To_Fill)
        {
            OleDbCommand FindItem = new OleDbCommand
            {
                CommandText = SELECT + FROM + JOIN + WHERE + ";",
                Connection = connect,
                CommandType = CommandType.Text
            };
            OleDbDataReader dataReader = FindItem.ExecuteReader();
            while (dataReader.Read())
            {
                @Combo_Box_To_Fill.Items.Add(dataReader[0]);
            }
            dataReader.Close();
        }

        public void GetData(int @Number_Of_Result)
        {
            size = Number_Of_Result;
            ResultGetData = new string[size];

            var get = new OleDbCommand()
            {
                Connection = connect,
                CommandText = SELECT + FROM + JOIN + WHERE + ";",
                CommandType = CommandType.Text
            };
            OleDbDataReader info = get.ExecuteReader();
            if (info.Read() == true)
            {
                int i = 0;
                for(i = 0; i < Number_Of_Result; i++)
                {
                    ResultGetData[i] = info[i].ToString();
                }
                
            }
            info.Close();
        }
    }
}

